using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class CtDienThoaiService : ICtDienThoaiService
    {
        private ICtDienThoaiRepository ctDienThoaiRepository;
        private IDienThoaiRepository dienThoaiRepository;
        private IBoNhoRepository boNhoRepository;
        private IMauSacRepository mauSacRepository;
        private IRamRepository ramRepository;
        private IChipRepository chipRepository;
        private IPinRepository pinRepository;
        private IManHinhRepository manHinhRepository;

        private IDienThoaiService dienThoaiService;
        private IBoNhoService boNhoService;
        private IMauSacService mauSacService;
        private IRamService ramService;
        private IChipService chipService;
        private IPinService pinService;
        private IManHinhService manHinhService;

        public CtDienThoaiService()
        {
            ctDienThoaiRepository = new CtDienThoaiRepository();
            dienThoaiRepository = new DienThoaiRepository();
            boNhoRepository = new BoNhoRepository();
            mauSacRepository = new MauSacRepository();
            ramRepository = new RamRepository();
            chipRepository = new ChipRepository();
            pinRepository = new PinRepository();
            manHinhRepository = new ManHinhRepository();

            dienThoaiService = new DienThoaiService();
            chipService = new ChipService();
            ramService = new RamService();
            pinService = new PinService();
            boNhoService = new BoNhoService();
            mauSacService = new MauSacService();
            manHinhService = new ManHinhService();
        }

        public string Add(CtDienThoaiView obj)
        {
            if (obj != null)
            {
                var CtDienThoai = new CtDienThoai()
                {
                    Id = Guid.Empty,
                    IdDt = dienThoaiService.GetId(obj.MaDt),
                    IdChip = chipService.GetId(obj.MaChip),
                    IdRam = ramService.GetId(obj.MaRam),
                    IdPin = pinService.GetId(obj.MaPin),
                    IdBoNho = boNhoService.GetId(obj.MaBoNho),
                    IdMauSac = mauSacService.GetId(obj.MaMauSac),
                    IdManHinh = manHinhService.GetId(obj.MaManHinh),
                    Ma = obj.Ma,
                    DuongDanAnh = obj.DuongDanAnh,
                    NgayNhap = obj.NgayNhap,
                    NamBh = obj.NamBh,
                    MoTa = obj.MoTa,
                    SoLuongTon = obj.SoLuongTon,
                    GiaNhap = obj.GiaNhap,
                    GiaBan = obj.GiaBan,
                    TrangThai = obj.TrangThai
                };
                return ctDienThoaiRepository.Add(CtDienThoai) ? "thêm thành công" : "thêm thất bại";
            }
            return "thêm thất bại";
        }

        public string Update(CtDienThoaiView obj)
        {
            if (obj != null)
            {
                var chiTietSp = GetModel(GetId(obj.Ma));
                chiTietSp.IdDt = dienThoaiService.GetId(obj.MaDt);
                chiTietSp.IdBoNho = boNhoService.GetId(obj.MaBoNho);
                chiTietSp.IdMauSac = mauSacService.GetId(obj.MaMauSac);
                chiTietSp.IdRam = ramService.GetId(obj.MaRam);
                chiTietSp.NamBh = obj.NamBh;
                chiTietSp.MoTa = obj.MoTa;
                chiTietSp.SoLuongTon = obj.SoLuongTon;
                chiTietSp.GiaNhap = obj.GiaNhap;
                chiTietSp.GiaBan = obj.GiaBan;
                chiTietSp.TrangThai = obj.TrangThai;
                return ctDienThoaiRepository.Update(chiTietSp) ? "sửa thành công" : "sửa thất bại";
            }
            return "sửa thất bại";
        }

        public string Delete(CtDienThoaiView obj)
        {
            if (obj != null)
            {
                var chiTietSp = GetModel(GetId(obj.Ma));
                return ctDienThoaiRepository.Delete(chiTietSp) ? "xóa thành công" : "xóa thất bại";
            }
            return "xóa thất bại";
        }

        public List<CtDienThoaiView> GetAll()
        {
            var lst = new List<CtDienThoaiView>();
            lst =
                (
                    from a in ctDienThoaiRepository.GetAll()
                    join b in dienThoaiRepository.GetAll() on a.IdDt equals b.Id
                    join c in chipRepository.GetAll() on a.IdChip equals c.Id
                    join d in ramRepository.GetAll() on a.IdRam equals d.Id
                    join e in pinRepository.GetAll() on a.IdPin equals e.Id
                    join f in boNhoRepository.GetAll() on a.IdBoNho equals f.Id
                    join g in manHinhRepository.GetAll() on a.IdManHinh equals g.Id
                    join h in mauSacRepository.GetAll() on a.IdMauSac equals h.Id
                    select new CtDienThoaiView()
                    {
                        Ma = a.Ma,
                        MaDt = b.Ma,
                        TenDt = b.Ten,
                        MaChip = c.Ma,
                        TenChip = c.Ten,
                        MaRam = d.Ma,
                        DungLuongRam = d.DungLuong,
                        MaPin = e.Ma,
                        DungLuongPin = e.DungLuong,
                        MaBoNho = f.Ma,
                        DungLuongBoNho = f.DungLuong,
                        MaManHinh = g.Ma,
                        KichThuocManHinh = g.KichThuoc,
                        MaMauSac = h.Ma,
                        TenMauSac = h.Ten,
                        NgayNhap = a.NgayNhap,
                        NamBh = a.NamBh,
                        MoTa = a.MoTa,
                        SoLuongTon = a.SoLuongTon,
                        GiaNhap = a.GiaNhap,
                        GiaBan = a.GiaBan,
                        TrangThai = a.TrangThai,
                    }
                ).ToList();
            return lst;
        }

        public List<CtDienThoaiView> GetAll(string input)
        {
            return string.IsNullOrEmpty(input) ? GetAll() : GetAll().Where(c => c.TenDt.Trim().ToLower().ToLower().Contains(input.Trim().ToLower())).ToList();
        }

        public CtDienThoai GetModel(Guid id)
        {
            return ctDienThoaiRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetId(string input)
        {
            return ctDienThoaiRepository.GetAll().FirstOrDefault(c => c.Ma == input).Id;
        }
    }
}
