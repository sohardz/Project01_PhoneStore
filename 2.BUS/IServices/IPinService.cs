using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IPinService
    {
        string Add(PinView obj);
        string Update(PinView obj);
        string Delete(PinView obj);
        List<PinView> GetAll();
        Pin GetModel(Guid id);
        Guid GetId(string input);
    }
}
