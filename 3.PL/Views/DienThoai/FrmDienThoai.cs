using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using _3.PL.Views.CtDienthoai;

namespace _3.PL.Views.DienThoai
{
    public partial class FrmDienThoai : Form
    {
        private IDienThoaiService dienThoaiService;
        private INsxService nsxService;
        private string maWhenClick;
        private FrmCtDienthoai FrmCtDienThoai;

        public FrmDienThoai(FrmCtDienthoai frmCtDienThoai)
        {
            InitializeComponent();
            dienThoaiService = new DienThoaiService();
            nsxService = new NsxService();
            LoadCmb();
            LoadDgrid(null);
            txt_ma.Enabled = false;
            FrmCtDienThoai = frmCtDienThoai;
        }

        public void LoadCmb()
        {
            cmb_nsx.Items.Clear();

            foreach (var x in nsxService.GetAll())
            {
                cmb_nsx.Items.Add(x.Ten);
            }
        }

        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_sanpham.ColumnCount = 5;
            dgrid_sanpham.Columns[0].Name = "STT";
            dgrid_sanpham.Columns[1].Name = "Mã";
            dgrid_sanpham.Columns[2].Name = "Tên";
            dgrid_sanpham.Columns[3].Name = "Nhà sản xuất";
            dgrid_sanpham.Columns[4].Name = "Trạng thái";
            dgrid_sanpham.Rows.Clear();

            foreach (var x in dienThoaiService.GetAll(input))
            {
                dgrid_sanpham.Rows.Add(stt++, x.Ma, x.Ten, x.TenNsx, Utility.TrangThai()[x.TrangThai]);
            }
        }

        private DienThoaiView GetDataFromGui()
        {

            var dienThoai = new DienThoaiView()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                MaNsx = nsxService.GetAll()[cmb_nsx.SelectedIndex].Ma,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return dienThoai;
        }

        private void dgrid_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.RowIndex != dienThoaiService.GetAll().Count)
            {
                int rowIndex = e.RowIndex;
                maWhenClick = dgrid_sanpham.Rows[rowIndex].Cells[1].Value.ToString();
                var obj = dienThoaiService.GetAll().FirstOrDefault(c => c.Ma == maWhenClick);
                txt_ma.Text = obj.Ma;
                txt_ten.Text = obj.Ten;
                cmb_nsx.SelectedIndex = nsxService.GetAll().FindIndex(c => c.Ma == obj.MaNsx);
                if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
                else rbtn_khonghoatdong.Checked = true;
            }
            else return;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();
            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "DT" + (dienThoaiService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in dienThoaiService.GetAll())
            {
                if (y.Ma == ma) ma = "DT" + (dienThoaiService.GetAll().Count + 1);
            }
            x.Ma = ma;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm điện thoại này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(dienThoaiService.Add(x));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa điện thoại này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(dienThoaiService.Update(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa điện thoại này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(dienThoaiService.Delete(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            cmb_nsx.SelectedIndex = -1;
            LoadDgrid(null);
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = Utility.VietHoaFullName(txt_ten.Text);
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            txt_timkiem.Text = "Tìm Kiếm ...";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text)) return;
            LoadDgrid(txt_timkiem.Text);
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            FrmNsx frmNsx = new(this);
            frmNsx.ShowDialog();
        }
    }
}
