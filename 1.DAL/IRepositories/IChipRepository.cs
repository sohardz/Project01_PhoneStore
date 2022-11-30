using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IChipRepository
    {
        bool Add(Chip obj);
        bool Update(Chip obj);
        bool Delete(Chip obj);
        List<Chip> GetAll();
    }
}
