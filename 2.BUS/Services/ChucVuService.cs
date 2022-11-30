using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class ChucVuService : IChucVuService
    {
        private IChucVuRepository chucVuRepository;

        public ChucVuService()
        {
            chucVuRepository = new ChucVuRepository();
        }

        public string Add(ChucVuView obj)
        {
            if (obj != null)
            {
                var chucVu = new ChucVu()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TrangThai = obj.TrangThai
                };
                return chucVuRepository.Add(chucVu) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(ChucVuView obj)
        {
            if (obj != null)
            {
                var chucVu = GetModel(GetId(obj.Ma));
                chucVu.Ten = obj.Ten;
                chucVu.TrangThai = obj.TrangThai;
                return chucVuRepository.Update(chucVu) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(ChucVuView obj)
        {
            if (obj != null)
            {
                var chucVu = GetModel(GetId(obj.Ma));
                return chucVuRepository.Delete(chucVu) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<ChucVuView> GetAll()
        {
            var lst = new List<ChucVuView>();
            lst =
                (
                    from a in chucVuRepository.GetAll()
                    select new ChucVuView()
                    {
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<ChucVuView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input)
                ? GetAll()
                : GetAll().Where(c => string.Equals(c.Ten.Trim(), input.Trim(), StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public ChucVu GetModel(Guid id)
        {
            return chucVuRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return chucVuRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
