using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IRamService
    {
        string Add(RamView obj);
        string Update(RamView obj);
        string Delete(RamView obj);
        List<RamView> GetAll();
        List<RamView> GetAll(string input);
        Ram GetModel(Guid id);
        Guid GetId(string input);
    }
}
