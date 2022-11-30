using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("DienThoai")]
    public partial class DienThoai
    {
        public DienThoai()
        {
            CtDienThoais = new HashSet<CtDienThoai>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid? IdNsx { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(100)]
        public string Ten { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(IdNsx))]
        [InverseProperty(nameof(Nsx.DienThoais))]
        public virtual Nsx IdNsxNavigation { get; set; }
        [InverseProperty(nameof(CtDienThoai.IdDtNavigation))]
        public virtual ICollection<CtDienThoai> CtDienThoais { get; set; }
    }
}
