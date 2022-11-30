using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private CuaHangDbContext dbContext;

        public KhachHangRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(KhachHang obj)
        {
            if (obj != null)
            {
                dbContext.KhachHangs.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(KhachHang obj)
        {
            if (obj != null)
            {
                var tempObj = dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
                tempObj.Ten = obj.Ten;
                tempObj.TenDem = obj.TenDem;
                tempObj.Ho = obj.Ho;
                tempObj.NgaySinh = obj.NgaySinh;
                tempObj.Sdt = obj.Sdt;
                tempObj.DiaChi = obj.DiaChi;
                tempObj.ThanhPho = obj.ThanhPho;
                dbContext.Update(tempObj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj != null)
            {
                var temp = dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<KhachHang> GetAll()
        {
            return dbContext.KhachHangs.ToList();
        }
    }
}
