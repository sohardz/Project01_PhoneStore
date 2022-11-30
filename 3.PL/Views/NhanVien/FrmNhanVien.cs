using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using System.ComponentModel.DataAnnotations;

namespace _3.PL.Views.NhanVien
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienService nhanVienService;
        private IChucVuService chucVuService;
        private string maWhenclick;
        private string ImagePath = "";
        private string img = @"D:\DuAn1\ProjectPhone\3.PL\Image\AnhNhanVien\1.jpg";

        public FrmNhanVien()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
            chucVuService = new ChucVuService();
            LoadCmb();
            LoadDgrid(null);
            txt_ma.Enabled = false;
        }

        public void LoadCmb()
        {
            cmb_chucvu.Items.Clear();
            cmb_locChucvu.Items.Clear();

            foreach (var x in chucVuService.GetAll())
            {
                cmb_chucvu.Items.Add(x.Ma + " " + x.Ten);
                cmb_locChucvu.Items.Add(x.Ma);
            }
        }

        private void LoadDgrid(string input)
        {
            int stt = 1;
            dgrid_nhanvien.ColumnCount = 11;
            dgrid_nhanvien.Columns[0].Name = "STT";
            dgrid_nhanvien.Columns[1].Name = "Mã";
            dgrid_nhanvien.Columns[2].Name = "Tên Đầy Đủ";
            dgrid_nhanvien.Columns[3].Name = "Cccd";
            dgrid_nhanvien.Columns[4].Name = "Ngày Sinh";
            dgrid_nhanvien.Columns[5].Name = "Giới Tính";
            dgrid_nhanvien.Columns[6].Name = "Địa Chỉ";
            dgrid_nhanvien.Columns[7].Name = "SĐT";
            dgrid_nhanvien.Columns[8].Name = "Email";
            dgrid_nhanvien.Columns[9].Name = "Chức Vụ";
            dgrid_nhanvien.Columns[10].Name = "Trạng Thái";
            dgrid_nhanvien.Rows.Clear();

            foreach (var x in nhanVienService.GetAll(input))
            {
                dgrid_nhanvien.Rows.Add(stt++, x.Ma, x.Ho + x.TenDem + x.Ten, x.Cccd, x.NgaySinh, x.GioiTinh == 1 ? "Nam" : "Nữ", x.DiaChi, x.Sdt, x.Email, x.TenCv, Utility.TrangThai()[x.TrangThai]);
            }
        }

        private bool CheckGetData(NhanVienView obj)
        {
            if (cmb_chucvu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!rbtn_nam.Checked && !rbtn_nu.Checked)
            {
                MessageBox.Show("Phải chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!rbtn_hoatdong.Checked && !rbtn_khonghoatdong.Checked)
            {
                MessageBox.Show("Phải chọn trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }

        private NhanVienView GetDataFromGui()
        {
            NhanVienView nvv = new NhanVienView()
            {
                Ma = txt_ma.Text,
                Ho = txt_ho.Text,
                TenDem = txt_tendem.Text,
                Ten = txt_ten.Text,
                Cccd = txt_cccd.Text,
                Email = txt_email.Text,
                GioiTinh = rbtn_nam.Checked ? 1 : 0,
                NgaySinh = dtpicker_ngaysinh.Value,
                DiaChi = txt_diachi.Text,
                Sdt = txt_sdt.Text,
                DuongDanAnh = ImagePath,
                MatKhau = txt_matkhau.Text,
                MaCv = chucVuService.GetAll()[cmb_chucvu.SelectedIndex].Ma,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return nvv;
        }

        private void dgrid_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.RowIndex != nhanVienService.GetAll().Count)
            {
                int rowIndex = e.RowIndex;
                maWhenclick = dgrid_nhanvien.Rows[rowIndex].Cells[1].Value.ToString().Trim();
                var obj = nhanVienService.GetAll().FirstOrDefault(x => x.Ma == maWhenclick);
                txt_ma.Text = obj.Ma;
                txt_ho.Text = obj.Ho;
                txt_tendem.Text = obj.TenDem;
                txt_ten.Text = obj.Ten;
                txt_cccd.Text = obj.Cccd;
                txt_email.Text = obj.Email;
                if (obj.GioiTinh == 1) rbtn_nam.Checked = true;
                else rbtn_nu.Checked = true;
                txt_diachi.Text = obj.DiaChi;
                txt_sdt.Text = obj.Sdt;
                dtpicker_ngaysinh.Value = obj.NgaySinh;
                txt_matkhau.Text = obj.MatKhau;
                if (obj.TrangThai == 0) rbtn_khonghoatdong.Checked = true;
                else rbtn_hoatdong.Checked = true;
                if (string.IsNullOrEmpty(obj.DuongDanAnh))
                {
                    picBox_anhNhanvien.Image = new Bitmap(img);
                }
                else picBox_anhNhanvien.Image = new Bitmap(obj.DuongDanAnh);
                cmb_chucvu.SelectedIndex = chucVuService.GetAll().FindIndex(c => c.Ma == obj.MaCv);
            }
            else return;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = GetDataFromGui();
            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "NV" + (nhanVienService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in nhanVienService.GetAll())
            {
                if (y.Ma == ma) ma = "NV" + (nhanVienService.GetAll().Count + 1);
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

            if (!CheckGetData(x)) return;

            DialogResult dialogResult = MessageBox.Show("bạn có chắc muốn thêm nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(nhanVienService.Add(x));
                LoadDgrid(null);
                LoadCmb();
            }
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

            if (!CheckGetData(x)) return;

            DialogResult dialogResult = MessageBox.Show("bạn có chắc muốn sửa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(nhanVienService.Update(x));
                LoadDgrid(null);
                LoadCmb();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ImagePath = "";
            picBox_anhNhanvien.Image = null;
            txt_ma.Text = "";
            txt_ho.Text = "";
            txt_tendem.Text = "";
            txt_ten.Text = "";
            txt_cccd.Text = "";
            txt_email.Text = "";
            rbtn_nam.Checked = true;
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_matkhau.Text = "";
            dtpicker_ngaysinh.Value = DateTime.Now;
            cmb_chucvu.Text = "";
            cmb_locChucvu.Text = "Lọc chức vụ";
            LoadDgrid(null);
        }

        private void btn_chucvuService_Click(object sender, EventArgs e)
        {
            FrmChucVu frmChucVu = new(this);
            frmChucVu.Show();
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
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text)) return;
            LoadDgrid(txt_timkiem.Text);
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            Utility.LoadImage(ref ImagePath);
            picBox_anhNhanvien.Image = new Bitmap(ImagePath);
        }
    }
}
