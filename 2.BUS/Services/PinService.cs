using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class PinService : IPinService
    {
        private IPinRepository pinRepository;

        public PinService()
        {
            pinRepository = new PinRepository();
        }

        public string Add(PinView obj)
        {
            if (obj != null)
            {
                var pin = new Pin()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    DungLuong = obj.DungLuong,
                    TrangThai = obj.TrangThai,
                };
                return pinRepository.Add(pin) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Delete(PinView obj)
        {
            if (obj != null)
            {
                var pin = GetModel(GetId(obj.Ma));
                return pinRepository.Delete(pin) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public string Update(PinView obj)
        {
            if (obj != null)
            {
                var pin = GetModel(GetId(obj.Ma));
                pin.DungLuong = obj.DungLuong;
                pin.TrangThai = obj.TrangThai;
                return pinRepository.Update(pin) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public List<PinView> GetAll()
        {
            var lst = new List<PinView>();
            lst =
                (
                    from a in pinRepository.GetAll()
                    select new PinView()
                    {
                        Ma = a.Ma,
                        DungLuong = a.DungLuong,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public Guid GetId(string input)
        {
            return pinRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }

        public Pin GetModel(Guid id)
        {
            return pinRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }


    }
}
