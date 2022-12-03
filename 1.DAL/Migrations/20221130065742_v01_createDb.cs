using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class v01_createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoNho",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DungLuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoNho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chip",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    Sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ThanhPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManHinh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KichThuoc = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManHinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DungLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DungLuong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdCv = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cccd = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    MatKhau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DuongDanAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_IdCv",
                        column: x => x.IdCv,
                        principalTable: "ChucVu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DienThoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienThoai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DienThoai_Nsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdKh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNv = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "date", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "date", nullable: true),
                    NgayShip = table.Column<DateTime>(type: "date", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "date", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_IdKh",
                        column: x => x.IdKh,
                        principalTable: "KhachHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDon_IdNv",
                        column: x => x.IdNv,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CtDienThoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdDt = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChip = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdRam = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPin = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdBoNho = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdManHinh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DuongDanAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime", nullable: false),
                    NamBh = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal(20,0)", nullable: false, defaultValueSql: "((0))"),
                    GiaBan = table.Column<decimal>(type: "decimal(20,0)", nullable: false, defaultValueSql: "((0))"),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtDienThoai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CtDienThoai_BoNho",
                        column: x => x.IdBoNho,
                        principalTable: "BoNho",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CtDienThoai_Chip",
                        column: x => x.IdChip,
                        principalTable: "Chip",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CtDienThoai_DienThoai",
                        column: x => x.IdDt,
                        principalTable: "DienThoai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CtDienThoai_ManHinh",
                        column: x => x.IdManHinh,
                        principalTable: "ManHinh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CtDienThoai_MauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CtDienThoai_Pin",
                        column: x => x.IdPin,
                        principalTable: "Pin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CtDienThoai_Ram",
                        column: x => x.IdRam,
                        principalTable: "Ram",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCtDienThoai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(20,0)", nullable: false, defaultValueSql: "((0))"),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK1_HoaDonChiTiet_HoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK2_HoaDonChiTiet_CtDienThoai",
                        column: x => x.IdCtDienThoai,
                        principalTable: "CtDienThoai",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IMEI",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdHoaDonChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaIMEI = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMEI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IMEI_HoaDonChiTiet",
                        column: x => x.IdHoaDonChiTiet,
                        principalTable: "HoaDonChiTiet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoNho_Ma",
                table: "BoNho",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chip_Ma",
                table: "Chip",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVu_Ma",
                table: "ChucVu",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_IdBoNho",
                table: "CtDienThoai",
                column: "IdBoNho");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_IdChip",
                table: "CtDienThoai",
                column: "IdChip");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_IdDt",
                table: "CtDienThoai",
                column: "IdDt");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_IdManHinh",
                table: "CtDienThoai",
                column: "IdManHinh");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_IdMauSac",
                table: "CtDienThoai",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_IdPin",
                table: "CtDienThoai",
                column: "IdPin");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_IdRam",
                table: "CtDienThoai",
                column: "IdRam");

            migrationBuilder.CreateIndex(
                name: "IX_CtDienThoai_Ma",
                table: "CtDienThoai",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DienThoai_IdNsx",
                table: "DienThoai",
                column: "IdNsx");

            migrationBuilder.CreateIndex(
                name: "IX_DienThoai_Ma",
                table: "DienThoai",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKh",
                table: "HoaDon",
                column: "IdKh");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNv",
                table: "HoaDon",
                column: "IdNv");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_Ma",
                table: "HoaDon",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdCtDienThoai",
                table: "HoaDonChiTiet",
                column: "IdCtDienThoai");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_Ma",
                table: "HoaDonChiTiet",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IMEI_IdHoaDonChiTiet",
                table: "IMEI",
                column: "IdHoaDonChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_IMEI_MaIMEI",
                table: "IMEI",
                column: "MaIMEI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_Ma",
                table: "KhachHang",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ManHinh_Ma",
                table: "ManHinh",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MauSac_Ma",
                table: "MauSac",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCv",
                table: "NhanVien",
                column: "IdCv");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_Ma",
                table: "NhanVien",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Nsx_Ma",
                table: "Nsx",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pin_Ma",
                table: "Pin",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ram_Ma",
                table: "Ram",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IMEI");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "CtDienThoai");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "BoNho");

            migrationBuilder.DropTable(
                name: "Chip");

            migrationBuilder.DropTable(
                name: "DienThoai");

            migrationBuilder.DropTable(
                name: "ManHinh");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "Pin");

            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "Nsx");
        }
    }
}
