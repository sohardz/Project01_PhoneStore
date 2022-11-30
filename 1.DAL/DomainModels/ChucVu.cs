using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("ChucVu")]
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(100)]
        public string Ten { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(NhanVien.IdCvNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
