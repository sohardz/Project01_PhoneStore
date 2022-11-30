using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.CtDienthoai
{
    public partial class FrmPin : Form
    {
        private IPinService pinService;
        private string maWhenclick;
        private FrmCtDienthoai FrmCtDienThoai;

        public FrmPin(FrmCtDienthoai frmCtDienThoai)
        {
            InitializeComponent();
            pinService = new PinService();
            LoadDgrid();
            txt_ma.Enabled = false;
            FrmCtDienThoai = frmCtDienThoai;
        }

        private void LoadDgrid()
        {
            int stt = 1;
            dgrid_pin.ColumnCount = 4;
            dgrid_pin.Columns[0].Name = "Stt";
            dgrid_pin.Columns[1].Name = "Mã";
            dgrid_pin.Columns[2].Name = "Dung Lượng";
            dgrid_pin.Columns[3].Name = "Trạng Thái";
            dgrid_pin.Rows.Clear();

            foreach (var x in pinService.GetAll())
            {
                dgrid_pin.Rows.Add(stt++, x.Ma, x.DungLuong + " mah", Utility.TrangThai()[x.TrangThai]);
            }
        }

        private PinView GetDataFromGui()
        {
            var pin = new PinView()
            {
                Ma = txt_ma.Text,
                DungLuong = Convert.ToInt32(txt_dungluong.Text),
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return pin;
        }

        private void dgrid_pin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == pinService.GetAll().Count) return;
            int rowIndex = e.RowIndex;
            maWhenclick = dgrid_pin.Rows[rowIndex].Cells[1].Value.ToString();
            var obj = pinService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
            txt_ma.Text = obj.Ma;
            txt_dungluong.Text = obj.DungLuong.ToString();
            if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
            else rbtn_khonghoatdong.Checked = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "PIN" + (pinService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in pinService.GetAll())
            {
                if (y.Ma == ma) ma = "PIN" + (pinService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm dung lượng pin này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(pinService.Add(x));
                LoadDgrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa dung lượng pin này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(pinService.Update(GetDataFromGui()));
                LoadDgrid();
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dung lượng pin này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(pinService.Delete(GetDataFromGui()));
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
