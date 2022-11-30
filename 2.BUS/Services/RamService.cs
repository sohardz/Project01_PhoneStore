using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class RamService : IRamService
    {
        private IRamRepository ramRepository;

        public RamService()
        {
            ramRepository = new RamRepository();
        }

        public string Add(RamView obj)
        {
            if (obj != null)
            {
                var ram = new Ram()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    DungLuong = obj.DungLuong,
                    TrangThai = obj.TrangThai,
                };
                return ramRepository.Add(ram) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(RamView obj)
        {
            if (obj != null)
            {
                var ram = GetModel(GetId(obj.Ma));
                ram.DungLuong = obj.DungLuong;
                ram.TrangThai = obj.TrangThai;
                return ramRepository.Update(ram) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(RamView obj)
        {
            if (obj != null)
            {
                var ram = GetModel(GetId(obj.Ma));
                return ramRepository.Delete(ram) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<RamView> GetAll()
        {
            var lst = new List<RamView>();
            lst =
                (
                    from a in ramRepository.GetAll()
                    select new RamView()
                    {
                        Ma = a.Ma,
                        DungLuong = a.DungLuong,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<RamView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input) ? GetAll() : GetAll().Where(c => c.Ma.Contains(input) || c.DungLuong.Trim().Contains(input.ToUpper().Trim())).ToList();
        }

        public Ram GetModel(Guid id)
        {
            return ramRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return ramRepository.GetAll().FirstOrDefault(c => c.Ma == input.Trim()).Id;
        }
    }
}
