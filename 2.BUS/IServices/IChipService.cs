using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IChipService
    {
        string Add(ChipView obj);
        string Update(ChipView obj);
        string Delete(ChipView obj);
        List<ChipView> GetAll();
        List<ChipView> GetAll(string input);
        Chip GetModel(Guid id);
        Guid GetId(string input);
    }
}
