﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(CuaHangDbContext))]
    partial class CuaHangDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.DomainModels.BoNho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DungLuong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("BoNho");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Chip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("Chip");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.CtDienThoai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DuongDanAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GiaBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal>("GiaNhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<Guid?>("IdBoNho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdChip")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDt")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdManHinh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPin")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdRam")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamBh")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdBoNho");

                    b.HasIndex("IdChip");

                    b.HasIndex("IdDt");

                    b.HasIndex("IdManHinh");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdPin");

                    b.HasIndex("IdRam");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("CtDienThoai");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.DienThoai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("IdNsx")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdNsx");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("DienThoai");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdKh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TenNguoiNhan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdKh");

                    b.HasIndex("IdNv");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<Guid?>("IdCtDienThoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCtDienThoai");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.IMEI", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("IdHoaDonChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaIMEI")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDonChiTiet");

                    b.HasIndex("MaIMEI")
                        .IsUnique()
                        .HasFilter("[MaIMEI] IS NOT NULL");

                    b.ToTable("IMEI");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ho")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TenDem")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ThanhPho")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ManHinh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<float>("KichThuoc")
                        .HasColumnType("real");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("ManHinh");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Cccd")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DuongDanAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("IdCv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TenDem")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdCv");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Nsx", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("Nsx");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Pin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<int>("DungLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("Pin");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Ram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DungLuong")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[Ma] IS NOT NULL");

                    b.ToTable("Ram");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.CtDienThoai", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.BoNho", "IdBoNhoNavigation")
                        .WithMany("CtDienThoais")
                        .HasForeignKey("IdBoNho")
                        .HasConstraintName("FK_CtDienThoai_BoNho");

                    b.HasOne("_1.DAL.DomainModels.Chip", "IdChipNavigation")
                        .WithMany("CtDienThoais")
                        .HasForeignKey("IdChip")
                        .HasConstraintName("FK_CtDienThoai_Chip");

                    b.HasOne("_1.DAL.DomainModels.DienThoai", "IdDtNavigation")
                        .WithMany("CtDienThoais")
                        .HasForeignKey("IdDt")
                        .HasConstraintName("FK_CtDienThoai_DienThoai");

                    b.HasOne("_1.DAL.DomainModels.ManHinh", "IdManHinhNavigation")
                        .WithMany("CtDienThoais")
                        .HasForeignKey("IdManHinh")
                        .HasConstraintName("FK_CtDienThoai_ManHinh");

                    b.HasOne("_1.DAL.DomainModels.MauSac", "IdMauSacNavigation")
                        .WithMany("CtDienThoais")
                        .HasForeignKey("IdMauSac")
                        .HasConstraintName("FK_CtDienThoai_MauSac");

                    b.HasOne("_1.DAL.DomainModels.Pin", "IdPinNavigation")
                        .WithMany("CtDienThoais")
                        .HasForeignKey("IdPin")
                        .HasConstraintName("FK_CtDienThoai_Pin");

                    b.HasOne("_1.DAL.DomainModels.Ram", "IdRamNavigation")
                        .WithMany("CtDienThoais")
                        .HasForeignKey("IdRam")
                        .HasConstraintName("FK_CtDienThoai_Ram");

                    b.Navigation("IdBoNhoNavigation");

                    b.Navigation("IdChipNavigation");

                    b.Navigation("IdDtNavigation");

                    b.Navigation("IdManHinhNavigation");

                    b.Navigation("IdMauSacNavigation");

                    b.Navigation("IdPinNavigation");

                    b.Navigation("IdRamNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.DienThoai", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.Nsx", "IdNsxNavigation")
                        .WithMany("DienThoais")
                        .HasForeignKey("IdNsx")
                        .HasConstraintName("FK_DienThoai_Nsx");

                    b.Navigation("IdNsxNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.KhachHang", "IdKhNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKh")
                        .HasConstraintName("FK_HoaDon_IdKh");

                    b.HasOne("_1.DAL.DomainModels.NhanVien", "IdNvNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNv")
                        .HasConstraintName("FK_HoaDon_IdNv");

                    b.Navigation("IdKhNavigation");

                    b.Navigation("IdNvNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.CtDienThoai", "IdCtDienThoaiNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdCtDienThoai")
                        .HasConstraintName("FK2_HoaDonChiTiet_CtDienThoai");

                    b.HasOne("_1.DAL.DomainModels.HoaDon", "IdHoaDonNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .HasConstraintName("FK1_HoaDonChiTiet_HoaDon");

                    b.Navigation("IdCtDienThoaiNavigation");

                    b.Navigation("IdHoaDonNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.IMEI", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.HoaDonChiTiet", "IdHoaDonChiTietNavigation")
                        .WithMany("IMEIs")
                        .HasForeignKey("IdHoaDonChiTiet")
                        .HasConstraintName("FK_IMEI_HoaDonChiTiet");

                    b.Navigation("IdHoaDonChiTietNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.ChucVu", "IdCvNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdCv")
                        .HasConstraintName("FK_NhanVien_IdCv");

                    b.Navigation("IdCvNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.BoNho", b =>
                {
                    b.Navigation("CtDienThoais");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Chip", b =>
                {
                    b.Navigation("CtDienThoais");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.CtDienThoai", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.DienThoai", b =>
                {
                    b.Navigation("CtDienThoais");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonChiTiet", b =>
                {
                    b.Navigation("IMEIs");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ManHinh", b =>
                {
                    b.Navigation("CtDienThoais");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.MauSac", b =>
                {
                    b.Navigation("CtDienThoais");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Nsx", b =>
                {
                    b.Navigation("DienThoais");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Pin", b =>
                {
                    b.Navigation("CtDienThoais");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.Ram", b =>
                {
                    b.Navigation("CtDienThoais");
                });
#pragma warning restore 612, 618
        }
    }
}
