using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class IMEIRepository : IIMEIRepository
    {
        private CuaHangDbContext dbContext;

        public IMEIRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(IMEI obj)
        {
            if (obj != null)
            {
                dbContext.IMEIs.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(IMEI obj)
        {
            if (obj != null)
            {
                var temp = dbContext.IMEIs.FirstOrDefault(c => c.Id == obj.Id);
                temp.IdHoaDonChiTiet = obj.IdHoaDonChiTiet;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(IMEI obj)
        {
            if (obj != null)
            {
                var temp = dbContext.IMEIs.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<IMEI> GetAll()
        {
            return dbContext.IMEIs.ToList();
        }
    }
}
