using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [StringLength(30)]
        public string TenDem { get; set; }
        [StringLength(30)]
        public string Ho { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(20)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string ThanhPho { get; set; }

        [InverseProperty(nameof(HoaDon.IdKhNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
