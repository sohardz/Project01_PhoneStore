using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IBoNhoRepository
    {
        bool Add(BoNho obj);
        bool Update(BoNho obj);
        bool Delete(BoNho obj);
        List<BoNho> GetAll();
    }
}
