using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("Nsx")]
    public partial class Nsx
    {
        public Nsx()
        {
            DienThoais = new HashSet<DienThoai>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(DienThoai.IdNsxNavigation))]
        public virtual ICollection<DienThoai> DienThoais { get; set; }
    }
}
