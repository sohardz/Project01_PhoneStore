using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IPinRepository
    {
        bool Add(Pin obj);
        bool Update(Pin obj);
        bool Delete(Pin obj);
        List<Pin> GetAll();
    }
}
