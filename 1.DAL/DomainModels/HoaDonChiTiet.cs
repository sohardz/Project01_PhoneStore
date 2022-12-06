using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        public HoaDonChiTiet()
        {            
        }

        [Key]
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid? IdCtDienThoai { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        public int SoLuong { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal DonGia { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(IdCtDienThoai))]
        [InverseProperty(nameof(CtDienThoai.HoaDonChiTiets))]
        public virtual CtDienThoai IdCtDienThoaiNavigation { get; set; }
        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }
    }
}
