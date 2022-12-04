using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IIMEIService
    {
        string Add(IMEIView obj);
        string Update(IMEIView obj);
        string Delete(IMEIView obj);
        List<IMEIView> GetAll();
        IMEI GetModel(Guid id);
        Guid GetId(string input);
    }
}
