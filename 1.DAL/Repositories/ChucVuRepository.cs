using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private CuaHangDbContext dbContext;

        public ChucVuRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(ChucVu obj)
        {
            if (obj != null)
            {
                dbContext.ChucVus.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(ChucVu obj)
        {
            if (obj != null)
            {
                var temp = dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
                temp.Ten = obj.Ten;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj != null)
            {
                var temp = dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ChucVu> GetAll()
        {
            return dbContext.ChucVus.ToList();
        }
    }
}
