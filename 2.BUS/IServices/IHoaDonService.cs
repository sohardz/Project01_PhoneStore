using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(HoaDonView obj);
        string Update(HoaDonView obj);
        string Delete(HoaDonView obj);
        List<HoaDonView> GetAll();
        HoaDon GetModel(Guid id);
        Guid GetId(string input);
    }
}
