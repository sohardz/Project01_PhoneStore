using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface INsxRepository
    {
        bool Add(Nsx obj);
        bool Update(Nsx obj);
        bool Delete(Nsx obj);
        List<Nsx> GetAll();
    }
}
