using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class MauSacService : IMauSacService
    {
        private IMauSacRepository mauSacRepository;

        public MauSacService()
        {
            mauSacRepository = new MauSacRepository();
        }

        public string Add(MauSacView obj)
        {
            if (obj != null)
            {
                var mauSac = new MauSac()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TrangThai = obj.TrangThai
                };
                return mauSacRepository.Add(mauSac) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(MauSacView obj)
        {
            if (obj != null)
            {
                var mauSac = GetModel(GetId(obj.Ma));
                mauSac.Ten = obj.Ten;
                mauSac.TrangThai = obj.TrangThai;
                return mauSacRepository.Update(mauSac) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(MauSacView obj)
        {
            if (obj != null)
            {
                var mauSac = GetModel(GetId(obj.Ma));
                return mauSacRepository.Delete(mauSac) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<MauSacView> GetAll()
        {
            var lst = new List<MauSacView>();
            lst =
                (
                    from a in mauSacRepository.GetAll()
                    select new MauSacView()
                    {
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<MauSacView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input) ? GetAll() : GetAll().Where(c => c.Ten.Contains(input.Trim().ToLower())).ToList();
        }

        public MauSac GetModel(Guid id)
        {
            return mauSacRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return mauSacRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
