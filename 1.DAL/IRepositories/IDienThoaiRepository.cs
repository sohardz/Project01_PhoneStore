using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IDienThoaiRepository
    {
        bool Add(DienThoai obj);
        bool Update(DienThoai obj);
        bool Delete(DienThoai obj);
        List<DienThoai> GetAll();
    }
}
