using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IIMEIRepository
    {
        bool Add(IMEI obj);
        bool Update(IMEI obj);
        bool Delete(IMEI obj);
        List<IMEI> GetAll();
    }
}
