using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private CuaHangDbContext dbContext;

        public HoaDonRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(HoaDon obj)
        {
            if (obj != null)
            {
                dbContext.HoaDons.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(HoaDon obj)
        {
            if (obj != null)
            {
                var temp = dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
                temp.IdNv = obj.IdNv;
                temp.IdKh = obj.IdKh;
                temp.NgayTao = obj.NgayTao;
                temp.NgayThanhToan = obj.NgayThanhToan;
                temp.GhiChu = obj.GhiChu;
                temp.TongTien = obj.TongTien;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj != null)
            {
                var temp = dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<HoaDon> GetAll()
        {
            return dbContext.HoaDons.ToList();
        }
    }
}
