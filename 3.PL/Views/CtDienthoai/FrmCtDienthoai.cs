using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using _3.PL.Views.DienThoai;

namespace _3.PL.Views.CtDienthoai
{
    public partial class FrmCtDienthoai : Form
    {
        private IDienThoaiService dienThoaiService;
        private IBoNhoService boNhoService;
        private IChipService chipService;
        private ICtDienThoaiService ctDienthoaiService;
        private IManHinhService manHinhService;
        private IMauSacService mauSacService;
        private IPinService pinService;
        private IRamService ramService;
        private string maWhenclick;
        private string ImagePath;
        private string img = @"C:\Users\adm\Desktop\DuAn1\3.PL\Image\AnhSanPham\1.jpg";

        public FrmCtDienthoai()
        {
            InitializeComponent();
            dienThoaiService = new DienThoaiService();
            boNhoService = new BoNhoService();
            chipService = new ChipService();
            ctDienthoaiService = new CtDienThoaiService();
            manHinhService = new ManHinhService();
            mauSacService = new MauSacService();
            pinService = new PinService();
            ramService = new RamService();
            LoadCmb();
            LoadDgrid();
            txt_ma.Enabled = false;
        }

        //Load combobox
        public void LoadCmb()
        {
            cmb_dienthoai.Items.Clear();
            cmb_chip.Items.Clear();
            cmb_ram.Items.Clear();
            cmb_pin.Items.Clear();
            cmb_bonho.Items.Clear();
            cmb_mausac.Items.Clear();
            cmb_manhinh.Items.Clear();

            foreach (var x in dienThoaiService.GetAll())
            {
                cmb_dienthoai.Items.Add(x.Ten);
            }

            foreach (var x in chipService.GetAll())
            {
                cmb_chip.Items.Add(x.Ten);
            }

            foreach (var x in ramService.GetAll())
            {
                cmb_ram.Items.Add(x.DungLuong);
            }

            foreach (var x in pinService.GetAll())
            {
                cmb_pin.Items.Add(x.DungLuong + " mah");
            }

            foreach (var x in boNhoService.GetAll())
            {
                cmb_bonho.Items.Add(x.DungLuong);
            }

            foreach (var x in mauSacService.GetAll())
            {
                cmb_mausac.Items.Add(x.Ten);
            }

            foreach (var x in manHinhService.GetAll())
            {
                cmb_manhinh.Items.Add(x.KichThuoc + " Inch");
            }
        }

        //Check Data with a stupid way
        private bool CheckGetData()
        {
            if (cmb_dienthoai.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmb_chip.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn chip", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmb_ram.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn ram", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmb_pin.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn điện pin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmb_bonho.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn bộ nhớ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmb_mausac.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn màu sắc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmb_manhinh.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn màn hình", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_soluong.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!int.TryParse(txt_soluong.Text, out _))
            {
                MessageBox.Show("Hãy nhập đúng định dạng cho số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_gianhap.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập giá nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!decimal.TryParse(txt_gianhap.Text, out _))
            {
                MessageBox.Show("Hãy nhập đúng định dạng cho giá nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_giaban.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập giá bán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!decimal.TryParse(txt_giaban.Text, out _))
            {
                MessageBox.Show("Hãy nhập đúng định dạng cho giá bán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_nambh.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập năm bảo hành", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!int.TryParse(txt_soluong.Text, out _))
            {
                MessageBox.Show("Hãy nhập đúng định dạng cho năm bảo hành", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rbtn_hoatdong.Checked && !rbtn_khonghoatdong.Checked)
            {
                MessageBox.Show("Hãy chọn trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return true;
        }

        //Load data gridview
        private void LoadDgrid()
        {
            int stt = 1;
            dgrid_chitietsp.ColumnCount = 15;
            dgrid_chitietsp.Columns[0].Name = "STT";
            dgrid_chitietsp.Columns[1].Name = "Mã";
            dgrid_chitietsp.Columns[2].Name = "Tên điện thoại";
            dgrid_chitietsp.Columns[3].Name = "Tên chip";
            dgrid_chitietsp.Columns[4].Name = "Dung lượng ram";
            dgrid_chitietsp.Columns[5].Name = "Dung lượng pin";
            dgrid_chitietsp.Columns[6].Name = "Dung lượng bộ nhớ";
            dgrid_chitietsp.Columns[7].Name = "Màu sắc";
            dgrid_chitietsp.Columns[8].Name = "Kích thước màn hình";
            dgrid_chitietsp.Columns[9].Name = "Ngày nhập";
            dgrid_chitietsp.Columns[10].Name = "Số lượng tồn";
            dgrid_chitietsp.Columns[11].Name = "Giá nhập";
            dgrid_chitietsp.Columns[12].Name = "Giá bán";
            dgrid_chitietsp.Columns[13].Name = "Năm bảo hành";
            dgrid_chitietsp.Columns[14].Name = "Mô tả";
            dgrid_chitietsp.Rows.Clear();

            foreach (var x in ctDienthoaiService.GetAll())
            {
                dgrid_chitietsp.Rows.Add(stt++, x.Ma, x.TenDt, x.TenChip, x.DungLuongRam, x.DungLuongPin + " mah", x.DungLuongBoNho, x.TenMauSac, x.KichThuocManHinh + " Inch", x.NgayNhap, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh, x.MoTa);
            }
        }

        //Get data from gui
        private CtDienThoaiView GetDataFromGui()
        {
            var ctDienThoai = new CtDienThoaiView()
            {
                Ma = txt_ma.Text,
                MaDt = dienThoaiService.GetAll()[cmb_dienthoai.SelectedIndex].Ma,
                MaChip = chipService.GetAll()[cmb_chip.SelectedIndex].Ma,
                MaRam = ramService.GetAll()[cmb_ram.SelectedIndex].Ma,
                MaPin = pinService.GetAll()[cmb_pin.SelectedIndex].Ma,
                MaBoNho = boNhoService.GetAll()[cmb_bonho.SelectedIndex].Ma,
                MaMauSac = mauSacService.GetAll()[cmb_mausac.SelectedIndex].Ma,
                MaManHinh = manHinhService.GetAll()[cmb_manhinh.SelectedIndex].Ma,
                NgayNhap = DateTime.Now,
                NamBh = Convert.ToInt32(txt_nambh.Text),
                SoLuongTon = Convert.ToInt32(txt_soluong.Text),
                GiaNhap = Convert.ToDecimal(txt_gianhap.Text),
                GiaBan = Convert.ToDecimal(txt_giaban.Text),
                MoTa = richtxt_mota.Text,
                DuongDanAnh = ImagePath,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
            };
            return ctDienThoai;
        }

        //dgrid cellclick
        private void dgrid_chitietsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == ctDienthoaiService.GetAll().Count) return;
            int rowIndex = e.RowIndex;
            maWhenclick = dgrid_chitietsp.Rows[rowIndex].Cells[1].Value.ToString();
            var ctdt = ctDienthoaiService.GetAll().FirstOrDefault(c => c.Ma == maWhenclick);
            txt_ma.Text = ctdt.Ma;
            cmb_dienthoai.SelectedIndex = dienThoaiService.GetAll().FindIndex(c => c.Ma == ctdt.MaDt);
            cmb_chip.SelectedIndex = chipService.GetAll().FindIndex(c => c.Ma == ctdt.MaChip);
            cmb_ram.SelectedIndex = ramService.GetAll().FindIndex(c => c.Ma == ctdt.MaRam);
            cmb_pin.SelectedIndex = pinService.GetAll().FindIndex(c => c.Ma == ctdt.MaPin);
            cmb_bonho.SelectedIndex = boNhoService.GetAll().FindIndex(c => c.Ma == ctdt.MaBoNho);
            cmb_mausac.SelectedIndex = mauSacService.GetAll().FindIndex(c => c.Ma == ctdt.MaMauSac);
            cmb_manhinh.SelectedIndex = manHinhService.GetAll().FindIndex(c => c.Ma == ctdt.MaManHinh);
            txt_soluong.Text = ctdt.SoLuongTon.ToString();
            txt_gianhap.Text = ctdt.GiaNhap.ToString();
            txt_giaban.Text = ctdt.GiaBan.ToString();
            txt_nambh.Text = ctdt.NamBh.ToString();
            richtxt_mota.Text = ctdt.MoTa;
            if (ctdt.TrangThai == 0) rbtn_khonghoatdong.Checked = true;
            else rbtn_hoatdong.Checked = true;
            if (string.IsNullOrEmpty(ctdt.DuongDanAnh))
            {
                picBox_anhNhanvien.Image = new Bitmap(img);
            }
            else picBox_anhNhanvien.Image = new Bitmap(ctdt.DuongDanAnh);
        }

        //thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!CheckGetData()) return;

            var x = GetDataFromGui();

            var ma = string.IsNullOrEmpty(txt_ma.Text) ? "CTDT" + (ctDienthoaiService.GetAll().Count + 1) : txt_ma.Text;
            foreach (var y in ctDienthoaiService.GetAll())
            {
                if (y.Ma == ma) ma = "CTDT" + (ctDienthoaiService.GetAll().Count + 1);
            }
            x.Ma = ma;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ctDienthoaiService.Add(x));
                LoadDgrid();
            }
        }

        //sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!CheckGetData()) return;

            var x = GetDataFromGui();

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ctDienthoaiService.Update(x));
                LoadDgrid();
            }
        }

        //clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_dienthoai.SelectedIndex = -1;
            cmb_chip.SelectedIndex = -1;
            cmb_ram.SelectedIndex = -1;
            cmb_pin.SelectedIndex = -1;
            cmb_bonho.SelectedIndex = -1;
            cmb_mausac.SelectedIndex = -1;
            cmb_manhinh.SelectedIndex = -1;
            txt_soluong.Text = "";
            txt_gianhap.Text = "";
            txt_giaban.Text = "";
            txt_nambh.Text = "";
            richtxt_mota.Text = "";
            LoadDgrid();
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
            //if (string.IsNullOrEmpty(txt_timkiem.Text)) return;
            //LoadDgrid();
        }
        #endregion

        #region button service
        private void btn_dienthoaiservice_Click(object sender, EventArgs e)
        {
            FrmDienThoai frmDienthoai = new(this);
            frmDienthoai.Show();
        }

        private void btn_chipService_Click(object sender, EventArgs e)
        {
            FrmChip frmChip = new(this);
            frmChip.Show();
        }

        private void btn_ram_Click(object sender, EventArgs e)
        {
            FrmRam frmRam = new(this);
            frmRam.Show();
        }

        private void btn_pinService_Click(object sender, EventArgs e)
        {
            FrmPin frmPin = new(this);
            frmPin.Show();
        }

        private void btn_bonho_Click(object sender, EventArgs e)
        {
            FrmBoNho frmBonho = new(this);
            frmBonho.Show();
        }

        private void btn_mausacservice_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMausac = new(this);
            frmMausac.Show();
        }

        private void btn_manhinhService_Click(object sender, EventArgs e)
        {
            FrmManHinh frmManhinh = new(this);
            frmManhinh.Show();
        }
        #endregion

        //lấy đường dẫn ảnh
        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            Utility.LoadImage(ref ImagePath);
            picBox_anhNhanvien.Image = new Bitmap(ImagePath);
        }
    }
}
