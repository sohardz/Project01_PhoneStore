using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        private CuaHangDbContext dbContext;

        public HoaDonChiTietRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            if (obj != null)
            {
                dbContext.HoaDonChiTiets.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj != null)
            {
                var temp = dbContext.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
                temp.SoLuong = obj.SoLuong;
                temp.DonGia = obj.DonGia;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj != null)
            {
                var temp = dbContext.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return dbContext.HoaDonChiTiets.ToList();
        }
    }
}
