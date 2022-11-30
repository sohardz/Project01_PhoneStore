using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository khachHangRepository;
        public KhachHangService()
        {
            khachHangRepository = new KhachHangRepository();
        }

        public string Add(KhachHangView obj)
        {
            if (obj != null)
            {
                var khachHang = new KhachHang()
                {
                    Id = Guid.Empty,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TenDem = obj.TenDem,
                    Ho = obj.Ho,
                    NgaySinh = obj.NgaySinh,
                    Sdt = obj.Sdt,
                    DiaChi = obj.DiaChi,
                    ThanhPho = obj.ThanhPho,
                };
                return khachHangRepository.Add(khachHang) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(KhachHangView obj)
        {
            if (obj != null)
            {
                var khachHang = GetModel(GetId(obj.Ma));
                khachHang.Ten = obj.Ten;
                khachHang.TenDem = obj.TenDem;
                khachHang.Ho = obj.Ho;
                khachHang.NgaySinh = obj.NgaySinh;
                khachHang.Sdt = obj.Sdt;
                khachHang.DiaChi = obj.DiaChi;
                khachHang.ThanhPho = obj.ThanhPho;
                return khachHangRepository.Update(khachHang) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(KhachHangView obj)
        {
            if (obj != null)
            {
                var khachHang = GetModel(GetId(obj.Ma));
                return khachHangRepository.Delete(khachHang) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<KhachHangView> GetAll()
        {
            var lst = new List<KhachHangView>();
            lst =
                (
                    from a in khachHangRepository.GetAll()
                    select new KhachHangView()
                    {
                        Ma = a.Ma,
                        Ten = a.Ten,
                        TenDem = a.TenDem,
                        Ho = a.Ho,
                        NgaySinh = a.NgaySinh,
                        Sdt = a.Sdt,
                        DiaChi = a.DiaChi,
                        ThanhPho = a.ThanhPho,
                    }
                ).ToList();
            return lst;
        }

        public List<KhachHangView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input) ? GetAll() : GetAll().Where(c => c.Ten.ToLower().Trim().StartsWith(input.ToLower().Trim())).ToList();
        }

        public KhachHang GetModel(Guid id)
        {
            return khachHangRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return khachHangRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
