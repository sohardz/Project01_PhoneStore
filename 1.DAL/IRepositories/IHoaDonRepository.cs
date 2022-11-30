using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        List<HoaDon> GetAll();
    }
}
