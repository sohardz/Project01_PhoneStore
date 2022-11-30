using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IManHinhRepository
    {
        bool Add(ManHinh obj);
        bool Update(ManHinh obj);
        bool Delete(ManHinh obj);
        List<ManHinh> GetAll();
    }
}
