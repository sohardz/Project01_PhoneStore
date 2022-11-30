using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.CtDienthoai
{
    public partial class FrmBoNho : Form
    {
        private IBoNhoService boNhoService;
        private string maWhenclick;
        private FrmCtDienthoai FrmCtDienThoai;

        public FrmBoNho(FrmCtDienthoai frmCtDienThoai)
        {
            InitializeComponent();
            boNhoService = new BoNhoService();
            LoadDgrid(null);
            txt_ma.Enabled = false;
            FrmCtDienThoai = frmCtDienThoai;
        }

        //load datagridview
        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_bonho.ColumnCount = 4;
            dgrid_bonho.Columns[0].Name = "Stt";
            dgrid_bonho.Columns[1].Name = "Mã";
            dgrid_bonho.Columns[2].Name = "Dung Lượng";
            dgrid_bonho.Columns[3].Name = "Trạng Thái";
            dgrid_bonho.Rows.Clear();

            foreach (var x in boNhoService.GetAll(input))
            {
                dgrid_bonho.Rows.Add(stt++, x.Ma, x.DungLuong, Utility.TrangThai()[x.TrangThai]);
            }
        }

        //get data from gui
        private BoNhoView GetDataFromGui()
        {

            var boNho = new BoNhoView()
            {
                Ma = txt_ma.Text,
                DungLuong = txt_dungluong.Text,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return boNho;
        }

        //cellclick
        private void dgrid_bonho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.RowIndex != boNhoService.GetAll().Count)
            {
                int rowIndex = e.RowIndex;
                maWhenclick = dgrid_bonho.Rows[rowIndex].Cells[1].Value.ToString();
                var obj = boNhoService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
                txt_ma.Text = obj.Ma;
                txt_dungluong.Text = obj.DungLuong;
                if (obj.TrangThai == 1) rbtn_hoatdong.Checked = true;
                else rbtn_khonghoatdong.Checked = true;
            }
            else return;
        }

        //thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "BN" + (boNhoService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in boNhoService.GetAll())
            {
                if (y.Ma == ma) ma = "BN" + (boNhoService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm dung lượng bộ nhớ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(boNhoService.Add(x));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        //sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa dung lượng bộ nhớ  này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(boNhoService.Update(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        //xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dung lượng bộ nhớ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(boNhoService.Delete(GetDataFromGui()));
                LoadDgrid(null);
                FrmCtDienThoai.LoadCmb();
            }
        }

        //clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_dungluong.Text = "";
            LoadDgrid(null);
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
