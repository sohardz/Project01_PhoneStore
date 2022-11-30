using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class PinRepository : IPinRepository
    {
        private CuaHangDbContext dbContext;

        public PinRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(Pin obj)
        {
            if (obj != null)
            {
                dbContext.Pins.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(Pin obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Pins.FirstOrDefault(c => c.Id == obj.Id);
                temp.DungLuong = obj.DungLuong;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp); return true;
            }
            return false;
        }

        public bool Delete(Pin obj)
        {
            if (obj != null)
            {
                var temp = dbContext.Pins.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges(); return true;
            }
            return false;
        }

        public List<Pin> GetAll()
        {
            return dbContext.Pins.ToList();
        }
    }
}
