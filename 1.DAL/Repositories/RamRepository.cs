using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class RamRepository : IRamRepository
    {
        private CuaHangDbContext dbContext;

        public RamRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(Ram obj)
        {
            if (obj != null)
            {
                dbContext.Rams.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(Ram obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Rams.FirstOrDefault(c => c.Id == obj.Id);
                temp.DungLuong = obj.DungLuong;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Ram obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Rams.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Ram> GetAll()
        {
            return dbContext.Rams.ToList();
        }
    }
}
