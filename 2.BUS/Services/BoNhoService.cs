using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class BoNhoService : IBoNhoService
    {
        private IBoNhoRepository boNhoRepository;

        public BoNhoService()
        {
            boNhoRepository = new BoNhoRepository();
        }

        public string Add(BoNhoView obj)
        {
            if (obj != null)
            {
                var boNho = new BoNho()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    DungLuong = obj.DungLuong,
                    TrangThai = obj.TrangThai,
                };
                return boNhoRepository.Add(boNho) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";

        }

        public string Update(BoNhoView obj)
        {
            if (obj != null)
            {
                var dongSp = GetModel(GetId(obj.Ma));
                dongSp.DungLuong = obj.DungLuong;
                dongSp.TrangThai = obj.TrangThai;
                return boNhoRepository.Update(dongSp) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(BoNhoView obj)
        {
            if (obj != null)
            {
                var dongSp = GetModel(GetId(obj.Ma));
                return boNhoRepository.Delete(dongSp) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<BoNhoView> GetAll()
        {
            var lst = new List<BoNhoView>();
            lst =
                (
                    from a in boNhoRepository.GetAll()
                    select new BoNhoView()
                    {
                        Ma = a.Ma,
                        DungLuong = a.DungLuong,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<BoNhoView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input)
                ? GetAll()
                : GetAll().Where(c => c.DungLuong.Contains(input.Trim().ToUpper())).ToList();
        }

        public BoNho GetModel(Guid id)
        {
            return boNhoRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return boNhoRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
