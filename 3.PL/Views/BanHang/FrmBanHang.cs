using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using _3.PL.Views.Stuff;
using System.Data;

namespace _3.PL.Views.BanHang
{
    public partial class FrmBanHang : Form
    {
        private NhanVienService nhanVienService;
        private CtDienThoaiService ctDienthoaiService;
        private KhachHangService khachHangService;
        private HoaDonService hoaDonService;
        private HoaDonChiTietService hoaDonChitietService;
        private IIMEIService imeiService;

        private List<HoaDonChiTietView> lstHdCt;
        public List<IMEIView> lstIMEI;
        private string maCthd;
        private string maCtdt;
        private string maHd;
        private KhachHangView khachHang;

        public FrmBanHang()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
            ctDienthoaiService = new CtDienThoaiService();
            khachHangService = new KhachHangService();
            hoaDonService = new HoaDonService();
            hoaDonChitietService = new HoaDonChiTietService();
            imeiService = new IMEIService();
            lstIMEI = new List<IMEIView>();
            lstHdCt = new List<HoaDonChiTietView>();
            LoadCmb();
            LoadSanPham();
            LoadHoaDonCho();
            LoadGioHang();
        }

        #region Load control
        private void LoadCmb()
        {
            cmb_customerPhoneNumber.Items.Clear();
            cmb_staff.Items.Clear();

            foreach (var x in khachHangService.GetAll())
            {
                cmb_customerPhoneNumber.Items.Add(x.Sdt);
            }

            foreach (var x in nhanVienService.GetAll())
            {
                cmb_staff.Items.Add(x.Sdt);
            }
        }

        private void LoadSanPham()
        {
            int stt = 1;
            dgrid_productDetail.ColumnCount = 5;
            dgrid_productDetail.Columns[0].Name = "STT";
            dgrid_productDetail.Columns[1].Name = "Mã";
            dgrid_productDetail.Columns[2].Name = "Tên sản phẩm";
            dgrid_productDetail.Columns[3].Name = "Số lượng tồn";
            dgrid_productDetail.Columns[4].Name = "Đơn giá";
            dgrid_productDetail.Rows.Clear();

            foreach (var x in ctDienthoaiService.GetAll())
            {
                dgrid_productDetail.Rows.Add(stt++, x.Ma, x.TenDt, x.SoLuongTon, x.GiaBan);
            }
        }

        private void LoadHoaDonCho()
        {
            int stt = 1;
            dgrid_undoneOrder.ColumnCount = 3;
            dgrid_undoneOrder.Columns[0].Name = "STT";
            dgrid_undoneOrder.Columns[1].Name = "Mã hóa đơn";
            dgrid_undoneOrder.Columns[2].Name = "Tên khách hàng";
            dgrid_undoneOrder.Rows.Clear();

            foreach (var x in hoaDonService.GetAll().Where(c => c.TrangThai == 0))
            {
                dgrid_undoneOrder.Rows.Add(stt++, x.Ma, x.TenKh);
            }
        }

        private void LoadGioHang()
        {
            int stt = 1;
            dgrid_orderDetail.ColumnCount = 6;
            dgrid_orderDetail.Columns[0].Name = "STT";
            dgrid_orderDetail.Columns[1].Name = "Mã CTHĐ";
            dgrid_orderDetail.Columns[2].Name = "Mã sản phẩm";
            dgrid_orderDetail.Columns[3].Name = "Tên sản phẩm";
            dgrid_orderDetail.Columns[4].Name = "Số lượng";
            dgrid_orderDetail.Columns[5].Name = "Đơn giá";
            dgrid_orderDetail.Columns[1].Visible = false;
            dgrid_orderDetail.Rows.Clear();

            foreach (var x in lstHdCt)
            {
                dgrid_orderDetail.Rows.Add(stt++, x.Ma, x.MaCtDienThoai, x.TenDt, x.SoLuong, x.DonGia);
            }
        }
        #endregion

        //tổng tiền
        private void TotalCart()
        {
            if (lstHdCt != null)
            {
                int total = 0;
                foreach (var x in lstHdCt)
                {
                    total += Convert.ToInt32(x.DonGia) * x.SoLuong;
                }
                lbl_totalcart.Text = total.ToString();
                //lbl_tongtien.Text = total.ToString();
            }
            else
            {
                lbl_totalcart.Text = "";
                //lbl_tongtien.Text = "";
            }
        }

        #region Thêm sản phẩm vào giỏ hàng
        private void AddProductToCart(string ma)
        {
            var ctdt = ctDienthoaiService.GetAll().FirstOrDefault(c => c.Ma == ma);
            var data = lstHdCt.FirstOrDefault(c => c.MaCtDienThoai == ctdt.Ma);
            if (data == null)
            {
                HoaDonChiTietView hoaDonctView = new HoaDonChiTietView()
                {
                    Ma = "HDCT" + Utility.GetNumber(9),
                    MaCtDienThoai = ctdt.Ma,
                    TenDt = ctdt.TenDt,
                    SoLuong = 1,
                    DonGia = ctdt.GiaBan,
                };
                lstHdCt.Add(hoaDonctView);
                TotalCart();
            }
            else
            {
                if (data.SoLuong == ctdt.SoLuongTon)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    data.SoLuong++;
                }
            }
            LoadGioHang();
        }
        #endregion


        //sản phẩm cellclick - lấy mã sản phẩm
        private void dgrid_productDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgrid_productDetail.RowCount - 1)
            {
                maCtdt = dgrid_productDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                AddProductToCart(maCtdt);
                TotalCart();
            }
            else return;
        }

        //hóa đơn chi tiết cellclick
        private void dgrid_orderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex <= dgrid_orderDetail.RowCount - 1)
            {
                maCtdt = dgrid_orderDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else return;
        }

        #region hóa đơn chờ cellclick
        private void dgrid_undoneOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrid_undoneOrder.RowCount - 1)
            {
                DataGridViewRow r = dgrid_undoneOrder.Rows[e.RowIndex];
                maHd = r.Cells[1].Value.ToString();
                var hoadonview = hoaDonService.GetAll().FirstOrDefault(c => c.Ma == maHd);
                var hoadonchitiet = hoaDonChitietService.GetAll(hoaDonService.GetId(hoadonview.Ma));
                txt_maOrder.Text = hoadonview.Ma;
                cmb_customerPhoneNumber.Text = khachHangService.GetAll().FirstOrDefault(c => c.Ma == hoadonview.MaKh).Sdt;
                cmb_staff.Text = nhanVienService.GetAll().FirstOrDefault(c => c.Ma == hoadonview.MaNv).Sdt;

                lstHdCt = new List<HoaDonChiTietView>();
                foreach (var item in hoadonchitiet)
                {
                    var sp = ctDienthoaiService.GetAll().FirstOrDefault(c => c.Ma == item.MaCtDienThoai);
                    HoaDonChiTietView hdct = new HoaDonChiTietView()
                    {
                        MaCtDienThoai = item.MaCtDienThoai,
                        TenDt = sp.TenDt,
                        DonGia = sp.GiaBan,
                        SoLuong = hoadonchitiet.FirstOrDefault(c => c.MaCtDienThoai == sp.Ma).SoLuong,
                    };
                    lstHdCt.Add(hdct);
                    LoadGioHang();
                }
                TotalCart();
                lbl_orderTotal.Text = lbl_totalcart.Text;
            }
            else return;
        }
        #endregion

        #region sửa số lượng giỏ hàng cellvaluechanged
        private void dgrid_orderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_orderDetail.Rows[e.RowIndex];
                if (int.TryParse(dgrid_orderDetail.Rows[r.Index].Cells[4].Value.ToString(), out int x))
                {
                    if (dgrid_orderDetail.Rows[r.Index].Cells[4].Value != lstHdCt[r.Index].SoLuong.ToString())
                    {
                        if (Convert.ToInt32(dgrid_orderDetail.Rows[r.Index].Cells[4].Value) <= 0)
                        {
                            MessageBox.Show("Nhập sai số lượng");
                            dgrid_orderDetail.Rows[r.Index].Cells[4].Value = lstHdCt[r.Index].SoLuong;
                        }
                        else
                        {
                            var p = ctDienthoaiService.GetAll().FirstOrDefault(x => x.Ma == lstHdCt[r.Index].MaCtDienThoai);
                            if (p.SoLuongTon < Convert.ToInt32(dgrid_orderDetail.Rows[r.Index].Cells[4].Value))
                            {
                                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                dgrid_orderDetail.Rows[r.Index].Cells[4].Value = lstHdCt[r.Index].SoLuong;
                            }
                            else
                            {
                                lstHdCt[r.Index].SoLuong = Convert.ToInt32(dgrid_orderDetail.Rows[r.Index].Cells[4].Value);
                                TotalCart();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai số lượng");
                    dgrid_orderDetail.Rows[r.Index].Cells[4].Value = lstHdCt[r.Index].SoLuong;
                }
            }
            else return;
        }
        #endregion

        #region thanh toán click
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (txt_maOrder.Text != "")
            {
                HoaDonView hoadon = hoaDonService.GetAll().FirstOrDefault(c => c.Ma.Equals(txt_maOrder.Text) && c.TrangThai == 0);
                if (hoadon == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                    lbl_orderTotal.Text = "0";
                }
                else
                {
                    var khachhang = khachHangService.GetAll().FirstOrDefault(c => c.Ma == hoadon.MaKh);
                    int x;

                    if (Convert.ToDecimal(lbl_change.Text) < 0 || txt_customerGive.Text == "" || !int.TryParse(txt_customerGive.Text, out int y) || y < 0)
                    {
                        MessageBox.Show("Vui lòng nhập đúng số tiền");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            hoadon.TrangThai = 1;
                            hoaDonService.Update(hoadon);
                            MessageBox.Show("Thanh toán thành công");
                            txt_sale.Text = "";
                            txt_customerGive.Text = "";
                            lbl_orderTotal.Text = "0";
                            lbl_change.Text = "0";
                            rtxt_note.Text = "";
                            LoadHoaDonCho();
                            lstHdCt = new List<HoaDonChiTietView>();
                            LoadGioHang();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
        }
        #endregion

        #region xử lí tiền khách đưa textchanged
        private void txt_customerGive_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_customerGive.Text == "" && txt_sale.Text == ""))
            {
                if (txt_sale.Text == "")
                {
                    if (decimal.TryParse(txt_customerGive.Text, out decimal _))
                    {
                        lbl_change.Text = (Convert.ToDecimal(txt_customerGive.Text) - Convert.ToDecimal(lbl_orderTotal.Text)).ToString();
                    }
                }
                else
                {
                    if (decimal.TryParse(txt_customerGive.Text, out decimal _) && decimal.TryParse(txt_sale.Text, out decimal _))
                    {
                        lbl_change.Text = (Convert.ToDecimal(txt_customerGive.Text) - Convert.ToDecimal(lbl_orderTotal.Text) + Convert.ToDecimal(txt_sale.Text)).ToString();
                    }
                }
            }
        }
        #endregion

        #region xóa sản phẩm khỏi giỏ hàng click
        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if (lstHdCt.Any())
            {
                var item = lstHdCt.FirstOrDefault(x => x.MaCtDienThoai == maCtdt);
                lstHdCt.Remove(item);
                LoadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }
        #endregion

        #region xóa giỏ hàng click
        private void btn_deleteCart_Click(object sender, EventArgs e)
        {
            if (lstHdCt.Any())
            {
                lstHdCt = new List<HoaDonChiTietView>();
                LoadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }
        #endregion

        #region thêm hóa đơn click 
        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            if (cmb_customerPhoneNumber.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa chọn khách hàng");
            }
            else if (cmb_staff.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa chọn nhân vien");
            }
            else
            {
                if (lstHdCt.Any())
                {
                    string maNhanvien = nhanVienService.GetAll().FirstOrDefault(c => c.Sdt == cmb_staff.Text).Ma;
                    khachHang = khachHangService.GetAll().FirstOrDefault(c => c.Sdt == cmb_customerPhoneNumber.Text);
                    if (khachHang != null)
                    {
                        HoaDonView hoadon = new HoaDonView()
                        {
                            Ma = "HD" + Utility.GetNumber(8),
                            NgayTao = DateTime.Now,
                            MaNv = maNhanvien,
                            MaKh = khachHang.Ma,
                            TrangThai = 0,
                            TenKh = khachHang.Ten,
                            TongTien = Convert.ToDecimal(lbl_totalcart.Text),
                        };
                        hoaDonService.Add(hoadon);
                        foreach (var item in lstHdCt)
                        {
                            item.MaHd = hoadon.Ma;
                            hoaDonChitietService.Add(item);
                            var sp = ctDienthoaiService.GetAll().FirstOrDefault(c => c.Ma == item.MaCtDienThoai);
                            sp.SoLuongTon -= item.SoLuong;
                            ctDienthoaiService.Update(sp);
                            for (int i = 0; i < item.SoLuong; i++)
                            {
                                IMEIView imei = new()
                                {
                                    MaCtDienThoai = item.MaCtDienThoai,
                                    MaHoaDonChiTiet = item.Ma,
                                    TrangThai = 1,
                                };
                                imeiService.Update(imei);
                            }
                        }

                        cmb_customerPhoneNumber.Text = "";
                        lbl_totalcart.Text = "";
                        MessageBox.Show($"Tạo hóa đơn thành công. ID: {hoadon.Ma}");
                        LoadSanPham();
                        LoadHoaDonCho();
                        lstHdCt = new List<HoaDonChiTietView>();
                        dgrid_orderDetail.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
        }
        #endregion

        #region cập nhật hóa đơn click 
        private void btn_updateOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maHd))
            {
                if (lstHdCt.Any())
                {
                    khachHang = khachHangService.GetAll().FirstOrDefault(c => c.Sdt == cmb_customerPhoneNumber.Text);
                    if (khachHang != null)
                    {
                        var hoadon = hoaDonService.GetAll().FirstOrDefault(c => c.Ma == maHd);
                        var hdct = hoaDonChitietService.GetAll(hoaDonService.GetId(hoadon.Ma));
                        foreach (var item in hdct)
                        {
                            IMEIView imei = new()
                            {
                                MaCtDienThoai = item.MaCtDienThoai,
                                MaHoaDonChiTiet = item.Ma,
                                TrangThai = 0,
                            };
                            imeiService.Update(imei);
                            item.MaHd = hoadon.Ma;
                            hoaDonChitietService.Delete(item);
                        }
                        foreach (var item in lstHdCt)
                        {
                            item.MaHd = hoadon.Ma;
                            hoaDonChitietService.Add(item);
                            var sp = ctDienthoaiService.GetAll().FirstOrDefault(c => c.Ma == item.MaCtDienThoai);
                            sp.SoLuongTon -= item.SoLuong;
                            ctDienthoaiService.Update(sp);
                            for (int i = 0; i < item.SoLuong; i++)
                            {
                                IMEIView imei = new()
                                {
                                    MaCtDienThoai = item.MaCtDienThoai,
                                    MaHoaDonChiTiet = item.Ma,
                                    TrangThai = 1,
                                };
                                imeiService.Update(imei);
                            }
                        }
                        string maNhanvien = nhanVienService.GetAll().FirstOrDefault(c => c.Sdt == cmb_staff.Text).Ma;
                        hoadon.MaNv = maNhanvien;
                        hoadon.MaKh = khachHang.Ma;
                        hoadon.TongTien = Convert.ToDecimal(lbl_totalcart.Text);
                        hoaDonService.Update(hoadon);

                        cmb_customerPhoneNumber.Text = "";
                        lbl_totalcart.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {hoadon.Ma}");
                        maHd = "";
                        LoadSanPham();
                        LoadHoaDonCho();
                        dgrid_orderDetail.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            }
        }
        #endregion        
    }
}
