using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class ManHinhService : IManHinhService
    {
        private IManHinhRepository manhinhRepository;

        public ManHinhService()
        {
            manhinhRepository = new ManHinhRepository();
        }

        public string Add(ManHinhView obj)
        {
            if (obj != null)
            {
                var manHinh = new ManHinh()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    KichThuoc = obj.KichThuoc,
                    TrangThai = obj.TrangThai,
                };
                return manhinhRepository.Add(manHinh) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }


        public string Update(ManHinhView obj)
        {
            if (obj != null)
            {
                var manHinh = GetModel(GetId(obj.Ma));
                manHinh.KichThuoc = obj.KichThuoc;
                manHinh.TrangThai = obj.TrangThai;
                return manhinhRepository.Update(manHinh) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(ManHinhView obj)
        {
            if (obj != null)
            {
                var manHinh = GetModel(GetId(obj.Ma));
                return manhinhRepository.Delete(manHinh) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<ManHinhView> GetAll()
        {
            var lst = new List<ManHinhView>();
            lst =
                (
                    from a in manhinhRepository.GetAll()
                    select new ManHinhView()
                    {
                        Ma = a.Ma,
                        KichThuoc = a.KichThuoc,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public Guid GetId(string input)
        {
            return manhinhRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }

        public ManHinh GetModel(Guid id)
        {
            return manhinhRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }


    }
}
