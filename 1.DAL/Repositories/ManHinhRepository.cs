using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class ManHinhRepository : IManHinhRepository
    {
        private CuaHangDbContext dbContext;

        public ManHinhRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(ManHinh obj)
        {
            if (obj != null)
            {
                dbContext.ManHinhs.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(ManHinh obj)
        {
            if (obj != null)
            {
                var temp = dbContext.ManHinhs.FirstOrDefault(c => c.Id == obj.Id);
                temp.KichThuoc = obj.KichThuoc;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(ManHinh obj)
        {
            if (obj != null)
            {
                var temp = dbContext.ManHinhs.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ManHinh> GetAll()
        {
            return dbContext.ManHinhs.ToList();
        }
    }
}
