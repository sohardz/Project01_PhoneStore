using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.CtDienthoai
{
    public partial class FrmMauSac : Form
    {
        private IMauSacService mauSacService;
        private string maWhenclick;
        private FrmCtDienthoai FrmCtDienThoai;

        public FrmMauSac(FrmCtDienthoai frmCtDienThoai)
        {
            InitializeComponent();
            mauSacService = new MauSacService();
            LoadDgrid(null);
            txt_ma.Enabled = false;
            FrmCtDienThoai = frmCtDienThoai;
        }

        //load datagridview
        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_mausac.ColumnCount = 4;
            dgrid_mausac.Columns[0].Name = "STT";
            dgrid_mausac.Columns[1].Name = "Mã";
            dgrid_mausac.Columns[2].Name = "Tên";
            dgrid_mausac.Columns[3].Name = "Trạng thái";
            dgrid_mausac.Rows.Clear();

            foreach (var x in mauSacService.GetAll(input))
            {
                dgrid_mausac.Rows.Add(stt++, x.Ma, x.Ten, Utility.TrangThai()[x.TrangThai]);
            }
        }

        //get data from gui
        private MauSacView GetDataFromGui()
        {
            var mauSac = new MauSacView()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return mauSac;
        }

        //cellclick
        private void dgrid_mausac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == mauSacService.GetAll().Count) return;
            int rowIndex = e.RowIndex;
            maWhenclick = dgrid_mausac.Rows[rowIndex].Cells[1].Value.ToString();
            var obj = mauSacService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
            if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
            else rbtn_khonghoatdong.Checked = true;
        }

        //thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "MS" + (mauSacService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in mauSacService.GetAll())
            {
                if (y.Ma == ma) ma = "MS" + (mauSacService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm màu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(mauSacService.Add(x));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        //sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa màu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(mauSacService.Update(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        //xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa màu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(mauSacService.Delete(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        //clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            LoadDgrid(null);
        }

        //viết hoa
        private void txt_ten_Leave(object sender, EventArgs e)
        {
            txt_ten.Text = Utility.VietHoaFullName(txt_ten.Text);
        }

        #region tìm kiếm
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
        #endregion
    }
}
