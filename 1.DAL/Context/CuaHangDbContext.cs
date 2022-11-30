using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.Context
{
    public partial class CuaHangDbContext : DbContext
    {
        public CuaHangDbContext()
        {
        }

        public CuaHangDbContext(DbContextOptions<CuaHangDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Chip> Chips { get; set; }
        public virtual DbSet<ManHinh> ManHinhs { get; set; }
        public virtual DbSet<Pin> Pins { get; set; }
        public virtual DbSet<Ram> Rams { get; set; }
        public virtual DbSet<BoNho> BoNhos { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<Nsx> Nsxes { get; set; }
        public virtual DbSet<DienThoai> DienThoais { get; set; }
        public virtual DbSet<CtDienThoai> CtDienThoais { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<IMEI> IMEIs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P5GSVI1\\SQLEXPRESS;Initial Catalog=nnnStore;Persist Security Info=True;User ID=cuongnpm;Password=123456");
                //optionsBuilder.UseSqlServer("Data Source=LEMINHHIEU\\SQLEXPRESS;Initial Catalog=DuAnPhone;Persist Security Info=True;User ID=lmaohieu;Password=1");
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-92GIOR2\\SQLEXPRESS01;Initial Catalog=DUAN1_banhang;Persist Security Info=True;User ID=dungtvph22973;Password=123456");
                //optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Duan1;Persist Security Info=True;User ID=tungndph;Password=abc");
                //optionsBuilder.UseSqlServer("Data Source=NKHOC\\SQLEXPRESS;Initial Catalog=nnnStore;Persist Security Info=True;User ID=hocnk;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Nsx>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<DienThoai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();

                entity.HasOne(e => e.IdNsxNavigation)
                    .WithMany(e => e.DienThoais)
                    .HasForeignKey(e => e.IdNsx)
                    .HasConstraintName("FK_DienThoai_Nsx");
            });

            modelBuilder.Entity<Chip>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<ManHinh>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<Pin>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<Ram>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<BoNho>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<CtDienThoai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");
                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.HasOne(e => e.IdDtNavigation)
                    .WithMany(e => e.CtDienThoais)
                    .HasForeignKey(e => e.IdDt)
                    .HasConstraintName("FK_CtDienThoai_DienThoai");

                entity.HasOne(e => e.IdChipNavigation)
                    .WithMany(e => e.CtDienThoais)
                    .HasForeignKey(e => e.IdChip)
                    .HasConstraintName("FK_CtDienThoai_Chip");

                entity.HasOne(e => e.IdRamNavigation)
                    .WithMany(e => e.CtDienThoais)
                    .HasForeignKey(e => e.IdRam)
                    .HasConstraintName("FK_CtDienThoai_Ram");

                entity.HasOne(e => e.IdPinNavigation)
                    .WithMany(e => e.CtDienThoais)
                    .HasForeignKey(e => e.IdPin)
                    .HasConstraintName("FK_CtDienThoai_Pin");

                entity.HasOne(e => e.IdBoNhoNavigation)
                    .WithMany(p => p.CtDienThoais)
                    .HasForeignKey(e => e.IdBoNho)
                    .HasConstraintName("FK_CtDienThoai_BoNho");

                entity.HasOne(e => e.IdManHinhNavigation)
                    .WithMany(e => e.CtDienThoais)
                    .HasForeignKey(e => e.IdManHinh)
                    .HasConstraintName("FK_CtDienThoai_ManHinh");

                entity.HasOne(e => e.IdMauSacNavigation)
                    .WithMany(e => e.CtDienThoais)
                    .HasForeignKey(e => e.IdMauSac)
                    .HasConstraintName("FK_CtDienThoai_MauSac");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
                entity.Property(e => e.MatKhau).IsUnicode(false);
                entity.Property(e => e.Sdt).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(e => e.IdCvNavigation)
                    .WithMany(e => e.NhanViens)
                    .HasForeignKey(e => e.IdCv)
                    .HasConstraintName("FK_NhanVien_IdCv");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
                entity.Property(e => e.Sdt).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(e => e.IdKhNavigation)
                    .WithMany(e => e.HoaDons)
                    .HasForeignKey(e => e.IdKh)
                    .HasConstraintName("FK_HoaDon_IdKh");

                entity.HasOne(e => e.IdNvNavigation)
                    .WithMany(e => e.HoaDons)
                    .HasForeignKey(e => e.IdNv)
                    .HasConstraintName("FK_HoaDon_IdNv");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.HasIndex(e => e.Ma).IsUnique();
                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.HasOne(e => e.IdHoaDonNavigation)
                    .WithMany(e => e.HoaDonChiTiets)
                    .HasForeignKey(e => e.IdHoaDon)
                    .HasConstraintName("FK1_HoaDonChiTiet_HoaDon");

                entity.HasOne(e => e.IdCtDienThoaiNavigation)
                    .WithMany(e => e.HoaDonChiTiets)
                    .HasForeignKey(e => e.IdCtDienThoai)
                    .HasConstraintName("FK2_HoaDonChiTiet_CtDienThoai");
            });

            modelBuilder.Entity<IMEI>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.HasIndex(e => e.MaIMEI).IsUnique();

                entity.HasOne(e => e.IdHoaDonChiTietNavigation)
                    .WithMany(e => e.IMEIs)
                    .HasForeignKey(e => e.IdHoaDonChiTiet)
                    .HasConstraintName("FK_IMEI_HoaDonChiTiet");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
