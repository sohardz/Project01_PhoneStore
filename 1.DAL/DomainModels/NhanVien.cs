using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _1.DAL.DomainModels
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid? IdCv { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [StringLength(30)]
        public string TenDem { get; set; }
        [StringLength(30)]
        public string Ho { get; set; }
        [StringLength(15)]
        public string Cccd { get; set; }
        public int GioiTinh { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(20)]
        public string Sdt { get; set; }
        [StringLength(75)]
        public string Email { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }
        public string DuongDanAnh { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(IdCv))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu IdCvNavigation { get; set; }

        [InverseProperty(nameof(HoaDon.IdNvNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
