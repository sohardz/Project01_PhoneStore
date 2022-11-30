using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IMauSacService
    {
        string Add(MauSacView obj);
        string Update(MauSacView obj);
        string Delete(MauSacView obj);
        List<MauSacView> GetAll();
        List<MauSacView> GetAll(string input);
        MauSac GetModel(Guid id);
        Guid GetId(string input);
    }
}
