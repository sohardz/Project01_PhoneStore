using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IBoNhoService
    {
        string Add(BoNhoView obj);
        string Update(BoNhoView obj);
        string Delete(BoNhoView obj);
        List<BoNhoView> GetAll();
        List<BoNhoView> GetAll(string input);
        BoNho GetModel(Guid id);
        Guid GetId(string input);
    }
}
