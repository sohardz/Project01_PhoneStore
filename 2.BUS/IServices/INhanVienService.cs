using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface INhanVienService
    {
        string Add(NhanVienView obj);
        string Update(NhanVienView obj);
        string Delete(NhanVienView obj);
        List<NhanVienView> GetAll();
        List<NhanVienView> GetAll(string input);
        NhanVien GetModel(Guid id);
        Guid GetId(string input);
    }
}
