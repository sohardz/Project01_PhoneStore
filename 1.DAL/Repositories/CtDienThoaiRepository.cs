using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class CtDienThoaiRepository : ICtDienThoaiRepository
    {
        private CuaHangDbContext dbContext;

        public CtDienThoaiRepository()
        {
            dbContext = new CuaHangDbContext();
        }

        public bool Add(CtDienThoai obj)
        {
            if (obj != null)
            {
                dbContext.CtDienThoais.Add(obj);
                dbContext.SaveChanges();
                return true;
            }
            return false;

        }

        public bool Update(CtDienThoai obj)
        {
            if (obj != null)
            {
                var temp = dbContext.CtDienThoais.FirstOrDefault(c => c.Id == obj.Id);
                temp.IdDt = obj.IdDt;
                temp.IdChip = obj.IdChip;
                temp.IdRam = obj.IdRam;
                temp.IdPin = obj.IdPin;
                temp.IdBoNho = obj.IdBoNho;
                temp.IdManHinh = obj.IdManHinh;
                temp.IdMauSac = obj.IdMauSac;
                temp.DuongDanAnh = obj.DuongDanAnh;
                temp.NamBh = obj.NamBh;
                temp.MoTa = obj.MoTa;
                temp.SoLuongTon = obj.SoLuongTon;
                temp.GiaBan = obj.GiaBan;
                temp.GiaNhap = obj.GiaNhap;
                temp.TrangThai = obj.TrangThai;
                dbContext.Update(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(CtDienThoai obj)
        {
            if (obj != null)
            {
                var temp = dbContext.CtDienThoais.FirstOrDefault(c => c.Id == obj.Id);
                dbContext.Remove(temp);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<CtDienThoai> GetAll()
        {
            return dbContext.CtDienThoais.ToList();
        }
    }
}
