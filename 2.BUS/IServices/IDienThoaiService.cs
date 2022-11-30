using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IDienThoaiService
    {
        string Add(DienThoaiView obj);
        string Update(DienThoaiView obj);
        string Delete(DienThoaiView obj);
        List<DienThoaiView> GetAll();
        List<DienThoaiView> GetAll(string input);
        DienThoai GetModel(Guid id);
        Guid GetId(string input);
    }
}
