using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class ChipRepository : IChipRepository
    {
        private CuaHangDbContext dbContext;

        public ChipRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(Chip obj)
        {
            if (obj != null)
            {
                dbContext.Chips.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(Chip obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Chips.FirstOrDefault(c => c.Id == obj.Id);
                temp.Ten = obj.Ten;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Chip obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Chips.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Chip> GetAll()
        {
            return dbContext.Chips.ToList();
        }
    }
}
