using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IMauSacRepository
    {
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        List<MauSac> GetAll();
    }
}
