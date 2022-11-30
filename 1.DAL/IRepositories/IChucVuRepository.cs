using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IChucVuRepository
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        List<ChucVu> GetAll();
    }
}
