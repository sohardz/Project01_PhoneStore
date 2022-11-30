using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class MauSacRepository : IMauSacRepository
    {
        private CuaHangDbContext dbContext;

        public MauSacRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(MauSac obj)
        {
            if (obj != null)
            {
                dbContext.MauSacs.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(MauSac obj)
        {
            if (obj != null)
            {
                var tempObj = dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
                tempObj.Ten = obj.Ten;
                tempObj.TrangThai = obj.TrangThai;
                dbContext.Update(tempObj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(MauSac obj)
        {
            if (obj != null)
            {
                var temp = dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<MauSac> GetAll()
        {
            return dbContext.MauSacs.ToList();
        }
    }
}
