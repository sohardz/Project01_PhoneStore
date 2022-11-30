using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("Pin")]
    public class Pin
    {
        public Pin()
        {
            CtDienThoais = new HashSet<CtDienThoai>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        public int DungLuong { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(CtDienThoai.IdPinNavigation))]
        public virtual ICollection<CtDienThoai> CtDienThoais { get; set; }
    }
}
