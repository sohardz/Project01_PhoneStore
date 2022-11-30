using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class DienThoaiRepository : IDienThoaiRepository
    {
        private CuaHangDbContext dbContext;

        public DienThoaiRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(DienThoai obj)
        {
            if (obj != null)
            {
                dbContext.DienThoais.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(DienThoai obj)
        {
            if (obj != null)
            {
                var temp = dbContext.DienThoais.FirstOrDefault(c => c.Id == obj.Id);
                temp.IdNsx = obj.IdNsx;
                temp.Ten = obj.Ten;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(DienThoai obj)
        {
            if (obj != null)
            {
                var temp = dbContext.DienThoais.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<DienThoai> GetAll()
        {
            return dbContext.DienThoais.ToList();
        }
    }
}
