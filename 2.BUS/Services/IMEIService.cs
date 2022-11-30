using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class IMEIService : IIMEIService
    {
        private IIMEIRepository imeiRepository;
        private IHoaDonChiTietRepository hoaDonChiTietRepository;

        private IHoaDonChiTietService hoaDonChiTietService;

        public IMEIService()
        {
            imeiRepository = new IMEIRepository();
            hoaDonChiTietRepository = new HoaDonChiTietRepository();

            hoaDonChiTietService = new HoaDonChiTietService();
        }

        public string Add(IMEIView obj)
        {
            if (obj != null)
            {
                var imei = new IMEI()
                {
                    Id = Guid.Empty,
                    IdHoaDonChiTiet = hoaDonChiTietService.GetId(obj.MaHoaDonChiTiet),
                    MaIMEI = obj.MaIMEI,
                    TrangThai = obj.TrangThai,
                };
                return imeiRepository.Add(imei) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(IMEIView obj)
        {
            if (obj != null)
            {
                var imei = GetModel(GetId(obj.MaIMEI));
                imei.TrangThai = obj.TrangThai;
                return imeiRepository.Update(imei) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(IMEIView obj)
        {
            if (obj != null)
            {
                var imei = GetModel(GetId(obj.MaIMEI));
                return imeiRepository.Delete(imei) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<IMEIView> GetAll()
        {
            var lst = new List<IMEIView>();
            lst =
                (
                    from a in imeiRepository.GetAll()
                    join b in hoaDonChiTietRepository.GetAll() on a.IdHoaDonChiTiet equals b.Id
                    select new IMEIView()
                    {
                        MaHoaDonChiTiet = b.Ma,
                        MaIMEI = a.MaIMEI,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public IMEI GetModel(Guid id)
        {
            return imeiRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(int input)
        {
            return imeiRepository.GetAll().FirstOrDefault(c => c.MaIMEI == input).Id;
        }
    }
}
