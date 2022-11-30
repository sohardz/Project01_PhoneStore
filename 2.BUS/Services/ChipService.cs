using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class ChipService : IChipService
    {
        private IChipRepository chipRepository;

        public ChipService()
        {
            chipRepository = new ChipRepository();
        }

        public string Add(ChipView obj)
        {
            if (obj != null)
            {
                var chip = new Chip()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TrangThai = obj.TrangThai,
                };
                return chipRepository.Add(chip) ? "Thêm thành công" : "Thêm thất bại";
            }
            return "Thêm thất bại";
        }

        public string Delete(ChipView obj)
        {
            if (obj != null)
            {
                var chip = GetModel(GetId(obj.Ma));
                return chipRepository.Delete(chip) ? "Xóa thành công" : "Xóa thất bại";
            }
            return "Xóa thất bại";
        }

        public List<ChipView> GetAll()
        {
            var lst = new List<ChipView>();
            lst =
                (
                    from a in chipRepository.GetAll()
                    select new ChipView()
                    {
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<ChipView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input) ? GetAll() : GetAll().Where(c => c.Ten.Trim().ToLower().Contains(input.Trim().ToLower())).ToList();
        }

        public Guid GetId(string input)
        {
            return chipRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }

        public Chip GetModel(Guid id)
        {
            return chipRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public string Update(ChipView obj)
        {
            if (obj != null)
            {
                var chip = chipRepository.GetAll().FirstOrDefault(c => c.Ma == obj.Ma);
                chip.Ten = obj.Ten;
                chip.TrangThai = obj.TrangThai;
                return chipRepository.Update(chip) ? "Sửa thành công" : "Sửa thất bại";
            }
            return "sửa thất bại";
        }
    }
}
