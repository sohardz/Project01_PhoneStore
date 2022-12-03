using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.NhanVien
{
    public partial class FrmChucVu : Form
    {
        private IChucVuService chucvuService;
        private string maWhenclick;
        private FrmNhanVien frmNhanVien;

        public FrmChucVu(FrmNhanVien FrmNhanVien)
        {
            InitializeComponent();
            chucvuService = new ChucVuService();
            LoadDgrid(null);
            txt_ma.Enabled = false;
            frmNhanVien = FrmNhanVien;
        }

        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_chucvu.ColumnCount = 4;
            dgrid_chucvu.Columns[0].Name = "STT";
            dgrid_chucvu.Columns[1].Name = "Mã";
            dgrid_chucvu.Columns[2].Name = "Tên";
            dgrid_chucvu.Columns[3].Name = "Trạng Thái";
            dgrid_chucvu.Rows.Clear();

            foreach (var x in chucvuService.GetAll(input))
            {
                dgrid_chucvu.Rows.Add(stt++, x.Ma, x.Ten, Utility.TrangThai()[x.TrangThai]);
            }
        }

        private ChucVuView GetDataFromGui()
        {

            var chucVu = new ChucVuView()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return chucVu;
        }

        private void dgrid_chucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == chucvuService.GetAll().Count) return;
            int rowIndex = e.RowIndex;
            maWhenclick = dgrid_chucvu.Rows[rowIndex].Cells[1].Value.ToString();
            var obj = chucvuService.GetAll().FirstOrDefault(x => x.Ma == maWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
            if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
            else rbtn_khonghoatdong.Checked = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();
            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "CV" + (chucvuService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in chucvuService.GetAll())
            {
                if (y.Ma == ma) ma = "CV" + (chucvuService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm chức vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(chucvuService.Add(x));
                LoadDgrid(null);
                frmNhanVien.LoadCmb();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa chức vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(chucvuService.Update(GetDataFromGui()));
                LoadDgrid(null);
                frmNhanVien.LoadCmb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa chức vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(chucvuService.Delete(GetDataFromGui()));
                LoadDgrid(null);
                frmNhanVien.LoadCmb();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            LoadDgrid(null);
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

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = Utility.VietHoaFullName(txt_ten.Text);
        }
    }
}
