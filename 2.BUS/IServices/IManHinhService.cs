using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IManHinhService
    {
        string Add(ManHinhView obj);
        string Update(ManHinhView obj);
        string Delete(ManHinhView obj);
        List<ManHinhView> GetAll();
        ManHinh GetModel(Guid id);
        Guid GetId(string input);
    }
}
