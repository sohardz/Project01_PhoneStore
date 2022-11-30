using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IHoaDonChiTietService
    {
        string Add(HoaDonChiTietView obj);
        string Update(HoaDonChiTietView obj);
        string Delete(HoaDonChiTietView obj);
        List<HoaDonChiTietView> GetAll(Guid id);
        List<HoaDonChiTietView> ShowHoadonChitiet(Guid id);
        HoaDonChiTiet GetModel(Guid id);
        Guid GetId(string input);
    }
}
