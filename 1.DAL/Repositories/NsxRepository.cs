using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class NsxRepository : INsxRepository
    {
        private CuaHangDbContext dbContext;

        public NsxRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(Nsx obj)
        {
            if (obj != null)
            {
                dbContext.Nsxes.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(Nsx obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
                temp.Ten = obj.Ten;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Nsx obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Nsx> GetAll()
        {
            return dbContext.Nsxes.ToList();
        }
    }
}
