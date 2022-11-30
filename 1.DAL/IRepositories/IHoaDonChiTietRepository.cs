using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTietRepository
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        List<HoaDonChiTiet> GetAll();
    }
}
