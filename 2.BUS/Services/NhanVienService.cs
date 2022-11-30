using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository nhanVienRepository;
        private IChucVuRepository chucVuRepository;

        private IChucVuService chucVuService;

        public NhanVienService()
        {
            nhanVienRepository = new NhanVienRepository();
            chucVuRepository = new ChucVuRepository();

            chucVuService = new ChucVuService();
        }
        public string Add(NhanVienView obj)
        {
            if (obj != null)
            {
                var nhanVien = new NhanVien()
                {
                    Id = Guid.Empty,
                    IdCv = chucVuService.GetId(obj.MaCv),
                    Ma = obj.Ma,
                    Ho = obj.Ho,
                    TenDem = obj.TenDem,
                    Ten = obj.Ten,
                    Cccd = obj.Cccd,
                    GioiTinh = obj.GioiTinh,
                    NgaySinh = obj.NgaySinh,
                    DiaChi = obj.DiaChi,
                    Sdt = obj.Sdt,
                    MatKhau = obj.MatKhau,
                    Email = obj.Email,
                    DuongDanAnh = obj.DuongDanAnh,
                    TrangThai = obj.TrangThai,
                };
                return nhanVienRepository.Add(nhanVien) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(NhanVienView obj)
        {
            if (obj != null)
            {
                var nhanVien = GetModel(GetId(obj.Ma));
                nhanVien.Ma = obj.Ma;
                nhanVien.IdCv = chucVuService.GetId(obj.MaCv);
                nhanVien.Ho = obj.Ho;
                nhanVien.TenDem = obj.TenDem;
                nhanVien.Ten = obj.Ten;
                nhanVien.Cccd = obj.Cccd;
                nhanVien.GioiTinh = obj.GioiTinh;
                nhanVien.NgaySinh = obj.NgaySinh;
                nhanVien.DiaChi = obj.DiaChi;
                nhanVien.Sdt = obj.Sdt;
                nhanVien.MatKhau = obj.MatKhau;
                nhanVien.Email = obj.Email;
                nhanVien.DuongDanAnh = obj.DuongDanAnh;
                nhanVien.TrangThai = obj.TrangThai;
                return nhanVienRepository.Update(nhanVien) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";

        }

        public string Delete(NhanVienView obj)
        {
            if (obj != null)
            {
                var nhanVien = GetModel(GetId(obj.Ma));
                return nhanVienRepository.Delete(nhanVien) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";

        }

        public List<NhanVienView> GetAll()
        {
            var lst = new List<NhanVienView>();
            lst =
                (
                    from a in nhanVienRepository.GetAll()
                    join b in chucVuRepository.GetAll() on a.IdCv equals b.Id
                    select new NhanVienView()
                    {
                        Ma = a.Ma,
                        MaCv = b.Ma,
                        TenCv = b.Ten,
                        Ho = a.Ho,
                        TenDem = a.TenDem,
                        Ten = a.Ten,
                        Cccd = a.Cccd,
                        GioiTinh = a.GioiTinh,
                        NgaySinh = a.NgaySinh,
                        DiaChi = a.DiaChi,
                        Sdt = a.Sdt,
                        Email = a.Email,
                        MatKhau = a.MatKhau,
                        DuongDanAnh = a.DuongDanAnh,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<NhanVienView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input) ? GetAll() : GetAll().Where(c => c.Ten.ToLower().Trim().StartsWith(input.ToLower().Trim()) || c.TenCv.Trim().ToLower().Equals(input.Trim().ToLower())).ToList();
        }

        public NhanVien GetModel(Guid id)
        {
            return nhanVienRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return nhanVienRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
