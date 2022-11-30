using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        private IHoaDonRepository hoaDonRepository;
        private IHoaDonChiTietRepository hoaDonChiTietRepository;
        private ICtDienThoaiRepository ctDienThoaiRepository;
        private IDienThoaiRepository dienThoaiRepository;

        private ICtDienThoaiService ctDienThoaiService;
        private IHoaDonService hoaDonService;

        public HoaDonChiTietService()
        {
            hoaDonChiTietRepository = new HoaDonChiTietRepository();
            hoaDonRepository = new HoaDonRepository();
            ctDienThoaiRepository = new CtDienThoaiRepository();
            dienThoaiRepository = new DienThoaiRepository();

            ctDienThoaiService = new CtDienThoaiService();
            hoaDonService = new HoaDonService();
        }

        public string Add(HoaDonChiTietView obj)
        {
            if (obj != null)
            {
                var hoaDonChiTiet = new HoaDonChiTiet()
                {
                    Id = Guid.Empty,
                    IdHoaDon = hoaDonService.GetId(obj.MaHd),
                    IdCtDienThoai = ctDienThoaiService.GetId(obj.MaCtDienThoai),
                    Ma = obj.Ma,
                    SoLuong = obj.SoLuong,
                    DonGia = obj.DonGia,
                    TrangThai = obj.TrangThai,
                };
                return hoaDonChiTietRepository.Add(hoaDonChiTiet) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(HoaDonChiTietView obj)
        {
            if (obj != null)
            {
                var hoaDonChiTiet = GetModel(GetId(obj.Ma));
                hoaDonChiTiet.SoLuong = obj.SoLuong;
                hoaDonChiTiet.DonGia = obj.DonGia;
                hoaDonChiTiet.TrangThai = obj.TrangThai;
                return hoaDonChiTietRepository.Update(hoaDonChiTiet) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(HoaDonChiTietView obj)
        {
            if (obj != null)
            {
                var hoaDonChiTiet = GetModel(GetId(obj.Ma));
                return hoaDonChiTietRepository.Delete(hoaDonChiTiet) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<HoaDonChiTietView> GetAll(Guid id)
        {
            var lst = new List<HoaDonChiTietView>();
            lst =
                (
                    from a in hoaDonChiTietRepository.GetAll()
                    join b in hoaDonRepository.GetAll() on a.IdHoaDon equals b.Id
                    join c in ctDienThoaiRepository.GetAll() on a.IdCtDienThoai equals c.Id
                    where a.IdHoaDon == id
                    select new HoaDonChiTietView()
                    {
                        Ma = a.Ma,
                        MaHd = b.Ma,
                        MaCtDienThoai = c.Ma,
                        SoLuong = a.SoLuong,
                        DonGia = a.DonGia,
                        ThanhTien = a.SoLuong * a.DonGia,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<HoaDonChiTietView> ShowHoadonChitiet(Guid id)
        {
            var lst = new List<HoaDonChiTietView>();
            lst =
                (
                    from a in hoaDonChiTietRepository.GetAll()
                    join b in hoaDonRepository.GetAll() on a.IdHoaDon equals b.Id
                    join c in ctDienThoaiRepository.GetAll() on a.IdCtDienThoai equals c.Id
                    join d in dienThoaiRepository.GetAll() on c.IdDt equals d.Id
                    where a.IdHoaDon == id
                    select new HoaDonChiTietView()
                    {
                        Ma = c.Ma,
                        TenDt = d.Ten,
                        SoLuong = a.SoLuong,
                        DonGia = a.DonGia,
                        ThanhTien = a.SoLuong * a.DonGia,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public HoaDonChiTiet GetModel(Guid id)
        {
            return hoaDonChiTietRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return hoaDonChiTietRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
