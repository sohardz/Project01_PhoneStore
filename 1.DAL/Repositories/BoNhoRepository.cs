using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class BoNhoRepository : IBoNhoRepository
    {
        private CuaHangDbContext dbContext;

        public BoNhoRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(BoNho obj)
        {
            if (obj != null)
            {
                dbContext.BoNhos.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(BoNho obj)
        {
            if (obj != null)
            {
                var temp = dbContext.BoNhos.FirstOrDefault(c => c.Id == obj.Id);
                temp.DungLuong = obj.DungLuong;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(BoNho obj)
        {
            if (obj != null)
            {
                var temp = dbContext.BoNhos.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<BoNho> GetAll()
        {
            return dbContext.BoNhos.ToList();
        }
    }
}
