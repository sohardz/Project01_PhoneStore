using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("CtDienThoai")]
    public partial class CtDienThoai
    {
        public CtDienThoai()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid? IdDt { get; set; }
        public Guid? IdChip { get; set; }
        public Guid? IdRam { get; set; }
        public Guid? IdPin { get; set; }
        public Guid? IdBoNho { get; set; }
        public Guid? IdManHinh { get; set; }
        public Guid? IdMauSac { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        public string DuongDanAnh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayNhap { get; set; }
        public int NamBh { get; set; }
        public string MoTa { get; set; }
        public int SoLuongTon { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal GiaNhap { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal GiaBan { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(IdManHinh))]
        [InverseProperty(nameof(ManHinh.CtDienThoais))]
        public virtual ManHinh IdManHinhNavigation { get; set; }
        [ForeignKey(nameof(IdChip))]
        [InverseProperty(nameof(Chip.CtDienThoais))]
        public virtual Chip IdChipNavigation { get; set; }
        [ForeignKey(nameof(IdPin))]
        [InverseProperty(nameof(Pin.CtDienThoais))]
        public virtual Pin IdPinNavigation { get; set; }
        [ForeignKey(nameof(IdRam))]
        [InverseProperty(nameof(Ram.CtDienThoais))]
        public virtual Ram IdRamNavigation { get; set; }
        [ForeignKey(nameof(IdBoNho))]
        [InverseProperty(nameof(BoNho.CtDienThoais))]
        public virtual BoNho IdBoNhoNavigation { get; set; }
        [ForeignKey(nameof(IdMauSac))]
        [InverseProperty(nameof(MauSac.CtDienThoais))]
        public virtual MauSac IdMauSacNavigation { get; set; }
        [ForeignKey(nameof(IdDt))]
        [InverseProperty(nameof(DienThoai.CtDienThoais))]
        public virtual DienThoai IdDtNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdCtDienThoaiNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
