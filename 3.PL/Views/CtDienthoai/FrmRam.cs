using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.CtDienthoai
{
    public partial class FrmRam : Form
    {
        private IRamService ramService;
        private string maWhenclick;
        private FrmCtDienthoai FrmCtDienThoai;

        public FrmRam(FrmCtDienthoai frmCtDienThoai)
        {
            InitializeComponent();
            ramService = new RamService();
            LoadDgrid();
            txt_ma.Enabled = false;
            FrmCtDienThoai = frmCtDienThoai;
        }


        private void LoadDgrid()
        {
            int stt = 1;
            dgrid_ram.ColumnCount = 4;
            dgrid_ram.Columns[0].Name = "Stt";
            dgrid_ram.Columns[1].Name = "Mã";
            dgrid_ram.Columns[2].Name = "Dung Lượng";
            dgrid_ram.Columns[3].Name = "Trạng Thái";
            dgrid_ram.Rows.Clear();

            foreach (var x in ramService.GetAll())
            {
                dgrid_ram.Rows.Add(stt++, x.Ma, x.DungLuong, Utility.TrangThai()[x.TrangThai]);
            }
        }

        private RamView GetDataFromGui()
        {
            var ram = new RamView()
            {
                Ma = txt_ma.Text,
                DungLuong = txt_dungluong.Text,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return ram;
        }

        private void dgrid_ram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == ramService.GetAll().Count) return;
            int rowIndex = e.RowIndex;
            maWhenclick = dgrid_ram.Rows[rowIndex].Cells[1].Value.ToString();
            var obj = ramService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
            txt_ma.Text = obj.Ma;
            txt_dungluong.Text = obj.DungLuong;
            if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
            else rbtn_khonghoatdong.Checked = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "RAM" + (ramService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in ramService.GetAll())
            {
                if (y.Ma == ma) ma = "RAM" + (ramService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm dung lượng ram này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ramService.Add(x));
                LoadDgrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa dung lượng ram này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ramService.Update(GetDataFromGui()));
                LoadDgrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dung lượng ram này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ramService.Delete(GetDataFromGui()));
                LoadDgrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_dungluong.Text = "";
            LoadDgrid();
        }
    }
}
