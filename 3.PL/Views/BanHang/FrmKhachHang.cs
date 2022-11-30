using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using System.ComponentModel.DataAnnotations;

namespace _3.PL.Views.BanHang
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangService khachHangService;
        private string maWhenclick;

        public FrmKhachHang()
        {
            InitializeComponent();
            khachHangService = new KhachHangService();
            LoadDgrid(null);
            LoadCmb();
            txt_ma.Enabled = false;
        }

        private void LoadCmb()
        {
            foreach (var x in Utility.GetThanhPho())
            {
                cmb_thanhpho.Items.Add(x);
            }
            cmb_thanhpho.SelectedIndex = 0;
        }

        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_khachhang.ColumnCount = 7;
            dgrid_khachhang.Columns[0].Name = "Stt";
            dgrid_khachhang.Columns[1].Name = "Mã";
            dgrid_khachhang.Columns[2].Name = "Họ và Tên";
            dgrid_khachhang.Columns[3].Name = "Ngày sinh";
            dgrid_khachhang.Columns[4].Name = "Sđt";
            dgrid_khachhang.Columns[5].Name = "Địa chỉ";
            dgrid_khachhang.Columns[6].Name = "Thành phố";
            dgrid_khachhang.Rows.Clear();

            foreach (var x in khachHangService.GetAll(input))
            {
                dgrid_khachhang.Rows.Add(stt++, x.Ma, x.Ho + x.TenDem + x.Ten, x.NgaySinh, x.Sdt, x.DiaChi, x.ThanhPho);
            }
        }

        private KhachHangView GetDataFromGui()
        {
            return new KhachHangView()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                TenDem = txt_tendem.Text,
                Ho = txt_ho.Text,
                NgaySinh = dtpicker_ngaysinh.Value,
                Sdt = txt_sdt.Text,
                DiaChi = txt_diachi.Text,
                ThanhPho = cmb_thanhpho.Text,
            };
        }

        private void dgrid_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == khachHangService.GetAll().Count) return;
            int rowIndex = e.RowIndex;
            maWhenclick = dgrid_khachhang.Rows[rowIndex].Cells[1].Value.ToString();
            var obj = khachHangService.GetAll().FirstOrDefault(x => x.Ma == maWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ho.Text = obj.Ho;
            txt_tendem.Text = obj.TenDem;
            txt_ten.Text = obj.Ten;
            dtpicker_ngaysinh.Value = obj.NgaySinh.Value;
            txt_sdt.Text = obj.Sdt;
            txt_diachi.Text = obj.DiaChi;
            cmb_thanhpho.Text = obj.ThanhPho;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "KH" + (khachHangService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in khachHangService.GetAll())
            {
                if (y.Ma == ma) ma = "KH" + (khachHangService.GetAll().Count + 1);
            }
            x.Ma = ma;

            ValidationContext validContext = new ValidationContext(x, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(x, validContext, errors, true))
            {
                foreach (var item in errors)
                {
                    MessageBox.Show(item.ErrorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(khachHangService.Add(x));
                LoadDgrid(null);
            }
            if (dialogResult == DialogResult.No) return;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();

            ValidationContext validContext = new ValidationContext(x, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(x, validContext, errors, true))
            {
                foreach (var item in errors)
                {
                    MessageBox.Show(item.ErrorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(khachHangService.Update(x));
                LoadDgrid(null);
            }
            if (dialogResult == DialogResult.No) return;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ho.Text = "";
            txt_tendem.Text = "";
            txt_ten.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            cmb_thanhpho.Text = "";
            dtpicker_ngaysinh.Value = DateTime.Now;
            LoadDgrid(null);
        }

        private void txt_ho_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ho.Text)) return;
            txt_ho.Text = Utility.VietHoaFullName(txt_ho.Text);
        }

        private void txt_tendem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tendem.Text)) return;
            txt_tendem.Text = Utility.VietHoaFullName(txt_tendem.Text);
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = Utility.VietHoaFullName(txt_ten.Text);
        }

        private void txt_diachi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_diachi.Text)) return;
            txt_diachi.Text = Utility.VietHoaFullName(txt_diachi.Text);
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            txt_timkiem.Text = "Tìm Kiếm ...";
            LoadDgrid(null);
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text)) return;
            LoadDgrid(txt_timkiem.Text);
        }
    }
}
