using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("Chip")]
    public class Chip
    {
        public Chip()
        {
            CtDienThoais = new HashSet<CtDienThoai>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(100)]
        public string Ten { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(CtDienThoai.IdChipNavigation))]
        public virtual ICollection<CtDienThoai> CtDienThoais { get; set; }
    }
}
