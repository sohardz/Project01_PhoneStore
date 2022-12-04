using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.CtDienthoai
{
    public partial class FrmChip : Form
    {
        private IChipService chipService;
        private string maWhenclick;
        private FrmCtDienthoai FrmCtDienThoai;

        public FrmChip(FrmCtDienthoai frmCtDienThoai)
        {
            InitializeComponent();
            chipService = new ChipService();
            LoadDgrid(null);
            txt_ma.Enabled = false;
            FrmCtDienThoai = frmCtDienThoai;
        }

        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_chip.ColumnCount = 4;
            dgrid_chip.Columns[0].Name = "Stt";
            dgrid_chip.Columns[1].Name = "Mã";
            dgrid_chip.Columns[2].Name = "Tên";
            dgrid_chip.Columns[3].Name = "Trạng Thái";
            dgrid_chip.Rows.Clear();

            foreach (var x in chipService.GetAll(input))
            {
                dgrid_chip.Rows.Add(stt++, x.Ma, x.Ten, Utility.TrangThai()[x.TrangThai]);
            }
        }

        private ChipView GetDataFromGui()
        {
            var chip = new ChipView()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return chip;
        }

        private void dgrid_chip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.RowIndex != chipService.GetAll().Count)
            {
                int rowIndex = e.RowIndex;
                maWhenclick = dgrid_chip.Rows[rowIndex].Cells[1].Value.ToString();
                var obj = chipService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
                txt_ma.Text = obj.Ma;
                txt_ten.Text = obj.Ten;
                if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
                else rbtn_khonghoatdong.Checked = true;
            }
            else return;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "CPU" + (chipService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in chipService.GetAll())
            {
                if (y.Ma == ma) ma = "CPU" + (chipService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm chip này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(chipService.Add(x));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa chip này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(chipService.Update(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa chip này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(chipService.Delete(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            LoadDgrid(null);
        }
    }
}
