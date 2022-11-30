using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class NsxService : INsxService
    {
        private INsxRepository nsxRepository;

        public NsxService()
        {
            nsxRepository = new NsxRepository();
        }

        public string Add(NsxView obj)
        {
            if (obj != null)
            {
                var nsx = new Nsx()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TrangThai = obj.TrangThai,
                };
                return nsxRepository.Add(nsx) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(NsxView obj)
        {
            if (obj != null)
            {
                var nsx = GetModel(GetId(obj.Ma));
                nsx.Ten = obj.Ten;
                nsx.TrangThai = obj.TrangThai;
                return nsxRepository.Update(nsx) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(NsxView obj)
        {
            if (obj != null)
            {
                var nsx = GetModel(GetId(obj.Ma));
                return nsxRepository.Delete(nsx) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<NsxView> GetAll()
        {
            var lst = new List<NsxView>();
            lst =
                (
                    from a in nsxRepository.GetAll()
                    select new NsxView()
                    {
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<NsxView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input) ? GetAll() : GetAll().Where(c => c.Ten.Contains(input.Trim().ToLower())).ToList();
        }

        public Nsx GetModel(Guid id)
        {
            return nsxRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return nsxRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
