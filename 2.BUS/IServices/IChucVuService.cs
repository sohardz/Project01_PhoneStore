using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IChucVuService
    {
        string Add(ChucVuView obj);
        string Update(ChucVuView obj);
        string Delete(ChucVuView obj);
        List<ChucVuView> GetAll();
        List<ChucVuView> GetAll(string input);
        ChucVu GetModel(Guid id);
        Guid GetId(string input);
    }
}
