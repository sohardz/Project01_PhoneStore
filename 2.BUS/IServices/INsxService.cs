using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface INsxService
    {
        string Add(NsxView obj);
        string Update(NsxView obj);
        string Delete(NsxView obj);
        List<NsxView> GetAll();
        List<NsxView> GetAll(string input);
        Nsx GetModel(Guid id);
        Guid GetId(string input);
    }
}
