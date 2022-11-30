using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("ManHinh")]
    public class ManHinh
    {
        public ManHinh()
        {
            CtDienThoais = new HashSet<CtDienThoai>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        public float KichThuoc { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(CtDienThoai.IdManHinhNavigation))]
        public virtual ICollection<CtDienThoai> CtDienThoais { get; set; }
    }
}
