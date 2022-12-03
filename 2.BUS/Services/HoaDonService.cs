using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository hoaDonRepository;
        private IKhachHangRepository khachHangRepository;
        private INhanVienRepository nhanVienRepository;

        private INhanVienService nhanVienSerivce;
        private IKhachHangService khachHangService;

        public HoaDonService()
        {
            hoaDonRepository = new HoaDonRepository();
            khachHangRepository = new KhachHangRepository();
            nhanVienRepository = new NhanVienRepository();

            khachHangService = new KhachHangService();
            nhanVienSerivce = new NhanVienService();
        }

        public string Add(HoaDonView obj)
        {
            if (obj != null)
            {
                var hoaDon = new HoaDon()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    IdKh = khachHangService.GetId(obj.MaKh),
                    IdNv = nhanVienSerivce.GetId(obj.MaNv),
                    NgayTao = obj.NgayTao,
                    NgayThanhToan = obj.NgayThanhToan,
                    TenNguoiNhan = obj.TenKh,
                    TongTien = obj.TongTien,
                    DiaChi = obj.DiaChi,
                    Sdt = obj.Sdt,
                    TrangThai = obj.TrangThai,
                };
                return hoaDonRepository.Add(hoaDon) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(HoaDonView obj)
        {
            if (obj != null)
            {
                var hoaDon = GetModel(GetId(obj.Ma));
                hoaDon.IdKh = khachHangService.GetId(obj.MaKh);
                hoaDon.IdNv = nhanVienSerivce.GetId(obj.MaNv);
                hoaDon.NgayTao = obj.NgayTao;
                hoaDon.NgayThanhToan = obj.NgayThanhToan;
                hoaDon.TenNguoiNhan = obj.TenKh;
                hoaDon.DiaChi = obj.DiaChi;
                hoaDon.TongTien = obj.TongTien;
                hoaDon.Sdt = obj.Sdt;
                hoaDon.TrangThai = obj.TrangThai;
                return hoaDonRepository.Update(hoaDon) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(HoaDonView obj)
        {
            if (obj != null)
            {
                var hoaDon = GetModel(GetId(obj.Ma));
                return hoaDonRepository.Delete(hoaDon) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<HoaDonView> GetAll()
        {
            var lst = new List<HoaDonView>();
            lst =
                (
                    from a in hoaDonRepository.GetAll()
                    join b in khachHangRepository.GetAll() on a.IdKh equals b.Id
                    join c in nhanVienRepository.GetAll() on a.IdNv equals c.Id
                    select new HoaDonView()
                    {
                        Ma = a.Ma,
                        MaNv = c.Ma,
                        MaKh = b.Ma,
                        NgayTao = a.NgayTao,
                        NgayThanhToan = a.NgayThanhToan,
                        TenKh = b.Ten,
                        TenNv = c.Ten,
                        DiaChi = b.DiaChi,
                        Sdt = b.Sdt,
                        TongTien = a.TongTien,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public HoaDon GetModel(Guid id)
        {
            return hoaDonRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return hoaDonRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
