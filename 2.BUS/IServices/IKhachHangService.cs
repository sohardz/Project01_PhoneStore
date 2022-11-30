using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        string Add(KhachHangView obj);
        string Update(KhachHangView obj);
        string Delete(KhachHangView obj);
        List<KhachHangView> GetAll();
        List<KhachHangView> GetAll(string input);
        KhachHang GetModel(Guid id);
        Guid GetId(string input);
    }
}
