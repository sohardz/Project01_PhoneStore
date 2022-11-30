using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        private CuaHangDbContext dbContext;

        public NhanVienRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(NhanVien obj)
        {
            if (obj != null)
            {
                dbContext.NhanViens.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(NhanVien obj)
        {
            if (obj != null)
            {
                var temp = dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
                temp.IdCv = obj.IdCv;
                temp.Ten = obj.Ten;
                temp.TenDem = obj.TenDem;
                temp.Ho = obj.Ho;
                temp.Cccd = obj.Cccd;
                temp.GioiTinh = obj.GioiTinh;
                temp.NgaySinh = obj.NgaySinh;
                temp.DiaChi = obj.DiaChi;
                temp.Sdt = obj.Sdt;
                temp.Email = obj.Email;
                temp.MatKhau = obj.MatKhau;
                temp.DuongDanAnh = obj.DuongDanAnh;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj != null)
            {
                var temp = dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<NhanVien> GetAll()
        {
            return dbContext.NhanViens.ToList();
        }
    }
}
