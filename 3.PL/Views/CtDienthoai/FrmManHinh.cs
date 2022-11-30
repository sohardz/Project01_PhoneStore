using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.CtDienthoai
{
    public partial class FrmManHinh : Form
    {
        IManHinhService manHinhService;
        string maWhenclick;
        private FrmCtDienthoai FrmCtDienThoai;

        public FrmManHinh(FrmCtDienthoai frmCtDienThoai)
        {
            InitializeComponent();
            manHinhService = new ManHinhService();
            LoadGrid();
            txt_ma.Enabled = false;
            FrmCtDienThoai = frmCtDienThoai;
        }

        private void LoadGrid()
        {
            int stt = 1;
            dgrid_manhinh.ColumnCount = 4;
            dgrid_manhinh.Columns[0].Name = "STT";
            dgrid_manhinh.Columns[1].Name = "Mã";
            dgrid_manhinh.Columns[2].Name = "Kích Thước";
            dgrid_manhinh.Columns[3].Name = "Trạng Thái";
            dgrid_manhinh.Rows.Clear();

            foreach (var x in manHinhService.GetAll())
            {
                dgrid_manhinh.Rows.Add(stt++, x.Ma, x.KichThuoc + " Inch", Utility.TrangThai()[x.TrangThai]);
            }
        }

        private ManHinhView GetDataFromGui()
        {
            return new ManHinhView()
            {
                Ma = txt_ma.Text,
                KichThuoc = (float)Convert.ToDouble(txt_kichthuoc.Text),
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
        }

        private void dgrid_manhinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.RowIndex != manHinhService.GetAll().Count)
            {
                int rowIndex = e.RowIndex;
                maWhenclick = dgrid_manhinh.Rows[rowIndex].Cells[1].Value.ToString();
                var obj = manHinhService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
                txt_ma.Text = obj.Ma;
                txt_kichthuoc.Text = obj.KichThuoc.ToString();
                if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
                else rbtn_khonghoatdong.Checked = true;
            }
            else return;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "MH" + (manHinhService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in manHinhService.GetAll())
            {
                if (y.Ma == ma) ma = "MH" + (manHinhService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn kích thước màn hình này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(manHinhService.Add(x));
                LoadGrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa kích thước màn hình này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(manHinhService.Update(GetDataFromGui()));
                LoadGrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa kích thước màn hình này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(manHinhService.Delete(GetDataFromGui()));
                LoadGrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_kichthuoc.Text = "";
            LoadGrid();
        }
    }
}
