using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface ICtDienThoaiRepository
    {
        bool Add(CtDienThoai obj);
        bool Update(CtDienThoai obj);
        bool Delete(CtDienThoai obj);
        List<CtDienThoai> GetAll();
    }
}
