using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("IMEI")]
    public partial class IMEI
    {
        public IMEI()
        {
        }

        [Key]
        public Guid Id { get; set; }
        public Guid? IdCtDienThoai { get; set; }
        public Guid? IdHoaDonChiTiet { get; set; }
        public string MaIMEI { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(IdCtDienThoai))]
        [InverseProperty(nameof(CtDienThoai.IMEIs))]
        public virtual CtDienThoai IdCtDienThoaiNavigation { get; set; }
    }
}
