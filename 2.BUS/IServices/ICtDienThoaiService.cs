using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface ICtDienThoaiService
    {
        string Add(CtDienThoaiView obj);
        string Update(CtDienThoaiView obj);
        string Delete(CtDienThoaiView obj);
        List<CtDienThoaiView> GetAll();
        List<CtDienThoaiView> GetAll(string input);
        CtDienThoai GetModel(Guid id);
        Guid GetId(string input);
    }
}
