using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("IMEI")]
    public partial class IMEI
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? IdHoaDonChiTiet { get; set; }
        public string MaIMEI { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(IdHoaDonChiTiet))]
        [InverseProperty(nameof(HoaDonChiTiet.IMEIs))]
        public virtual HoaDonChiTiet IdHoaDonChiTietNavigation { get; set; }
    }
}
