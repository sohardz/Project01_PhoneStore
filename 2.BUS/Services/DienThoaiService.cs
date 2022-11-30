using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class DienThoaiService : IDienThoaiService
    {
        private IDienThoaiRepository dienThoaiRepository;
        private INsxRepository nsxRepository;

        private INsxService nsxService;

        public DienThoaiService()
        {
            dienThoaiRepository = new DienThoaiRepository();
            nsxRepository = new NsxRepository();

            nsxService = new NsxService();
        }

        public string Add(DienThoaiView obj)
        {
            if (obj != null)
            {
                var sanPham = new DienThoai()
                {
                    Id = Guid.Empty,
                    IdNsx = nsxService.GetId(obj.MaNsx),
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TrangThai = obj.TrangThai,
                };
                return dienThoaiRepository.Add(sanPham) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(DienThoaiView obj)
        {
            if (obj != null)
            {
                var sanPham = GetModel(GetId(obj.Ma));
                sanPham.IdNsx = nsxService.GetId(obj.MaNsx);
                sanPham.Ten = obj.Ten;
                sanPham.TrangThai = obj.TrangThai;
                return dienThoaiRepository.Update(sanPham) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(DienThoaiView obj)
        {
            if (obj != null)
            {
                var sanPham = GetModel(GetId(obj.Ma));
                return dienThoaiRepository.Delete(sanPham) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<DienThoaiView> GetAll()
        {
            var lst = new List<DienThoaiView>();
            lst =
                (
                    from a in dienThoaiRepository.GetAll()
                    join c in nsxRepository.GetAll() on a.IdNsx equals c.Id
                    select new DienThoaiView()
                    {
                        Ma = a.Ma,
                        MaNsx = c.Ma,
                        TenNsx = c.Ten,
                        Ten = a.Ten,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<DienThoaiView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input)
                ? GetAll()
                : GetAll().Where(c => c.Ten.Trim().ToLower().Contains(input.Trim().ToLower())).ToList();
        }

        public DienThoai GetModel(Guid id)
        {
            return dienThoaiRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return dienThoaiRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
