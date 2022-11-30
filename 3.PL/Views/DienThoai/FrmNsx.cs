using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.DienThoai
{
    public partial class FrmNsx : Form
    {
        private INsxService nsxService;
        private string maWhenclick;
        private FrmDienThoai FrmDienThoai;

        public FrmNsx(FrmDienThoai frmDienThoai)
        {
            InitializeComponent();
            nsxService = new NsxService();
            LoadDgrid(null);
            txt_ma.Enabled = false;
            FrmDienThoai = frmDienThoai;
        }

        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_nsx.ColumnCount = 4;
            dgrid_nsx.Columns[0].Name = "STT";
            dgrid_nsx.Columns[1].Name = "Mã";
            dgrid_nsx.Columns[2].Name = "Tên";
            dgrid_nsx.Columns[3].Name = "Trạng Thai";
            dgrid_nsx.Rows.Clear();

            foreach (var x in nsxService.GetAll(input))
            {
                dgrid_nsx.Rows.Add(stt++, x.Ma, x.Ten, Utility.TrangThai()[x.TrangThai]);
            }
        }

        private NsxView GetDataFromGui()
        {
            var nsx = new NsxView()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0
            };
            return nsx;
        }

        private void dgrid_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == nsxService.GetAll().Count) return;
            int rowIndex = e.RowIndex;
            maWhenclick = dgrid_nsx.Rows[rowIndex].Cells[1].Value.ToString();
            var obj = nsxService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
            if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
            else rbtn_khonghoatdong.Checked = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();
            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "NSX" + (nsxService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in nsxService.GetAll())
            {
                if (y.Ma == ma) ma = "NSX" + (nsxService.GetAll().Count + 1);
            }
            x.Ma = ma;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm nhà sản xuất này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(nsxService.Add(x));
                LoadDgrid(null);
                FrmDienThoai.LoadCmb();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa nhà sản xuất này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(nsxService.Update(GetDataFromGui()));
                LoadDgrid(null);
                FrmDienThoai.LoadCmb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhà sản xuất này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(nsxService.Delete(GetDataFromGui()));
                LoadDgrid(null);
                FrmDienThoai.LoadCmb();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            LoadDgrid(null);
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
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
    }
}
