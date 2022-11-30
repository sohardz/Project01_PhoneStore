using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IRamRepository
    {
        bool Add(Ram obj);
        bool Update(Ram obj);
        bool Delete(Ram obj);
        List<Ram> GetAll();
    }
}
