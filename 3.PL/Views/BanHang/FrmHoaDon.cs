using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views.BanHang
{
    public partial class FrmHoaDon : Form
    {
        private IHoaDonChiTietService hoaDonChiTietService;
        private IHoaDonService hoaDonService;
        private string maHoadon;
        private List<HoaDonChiTietView> lstHdct;
        private int stt = 1;

        public FrmHoaDon()
        {
            InitializeComponent();
            hoaDonChiTietService = new HoaDonChiTietService();
            hoaDonService = new HoaDonService();
            LoadDgridHoaDon();
            SetupHoadonChitietDrgid();
        }

        private void LoadDgridHoaDon()
        {
            int stt = 1;
            dgrid_hoadon.ColumnCount = 7;
            dgrid_hoadon.Columns[0].Name = "STT";
            dgrid_hoadon.Columns[1].Name = "Mã";
            dgrid_hoadon.Columns[2].Name = "Tên nhân viên";
            dgrid_hoadon.Columns[3].Name = "Tên khách hàng";
            dgrid_hoadon.Columns[4].Name = "Ngày tạo";
            dgrid_hoadon.Columns[5].Name = "Tổng tiền";
            dgrid_hoadon.Columns[6].Name = "Trạng thái";
            dgrid_hoadon.Rows.Clear();

            foreach (var x in hoaDonService.GetAll())
            {
                dgrid_hoadon.Rows.Add(stt++, x.Ma, x.TenNv, x.TenKh, x.NgayTao, x.TongTien, Utility.TrangThai()[x.TrangThai]);
            }
        }

        private void SetupHoadonChitietDrgid()
        {
            dgrid_ctHoadon.ColumnCount = 7;
            dgrid_ctHoadon.Columns[0].Name = "STT";
            dgrid_ctHoadon.Columns[1].Name = "Mã";
            dgrid_ctHoadon.Columns[2].Name = "Tên sản phẩm";
            dgrid_ctHoadon.Columns[3].Name = "Đơn giá";
            dgrid_ctHoadon.Columns[4].Name = "Số lượng";
            dgrid_ctHoadon.Columns[5].Name = "Thành tiền";
            dgrid_ctHoadon.Columns[6].Name = "Trạng thái";
        }

        private void dgrid_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgrid_hoadon.RowCount - 1)
            {
                maHoadon = dgrid_hoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
                lstHdct = hoaDonChiTietService.ShowHoadonChitiet(hoaDonService.GetId(maHoadon));
                foreach (var x in lstHdct)
                {
                    dgrid_ctHoadon.Rows.Add(stt++, x.Ma, x.TenDt, x.DonGia, x.SoLuong, x.ThanhTien, x.TrangThai);
                }
            }
            else return;
        }
    }
}
