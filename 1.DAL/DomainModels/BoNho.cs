using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("BoNho")]
    public partial class BoNho
    {
        public BoNho()
        {
            CtDienThoais = new HashSet<CtDienThoai>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string DungLuong { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(CtDienThoai.IdBoNhoNavigation))]
        public virtual ICollection<CtDienThoai> CtDienThoais { get; set; }
    }
}
