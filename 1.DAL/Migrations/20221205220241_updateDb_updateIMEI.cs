using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class updateDb_updateIMEI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IMEI_HoaDonChiTiet",
                table: "IMEI");

            migrationBuilder.DropIndex(
                name: "IX_IMEI_IdHoaDonChiTiet",
                table: "IMEI");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCtDienThoai",
                table: "IMEI",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IMEI_IdCtDienThoai",
                table: "IMEI",
                column: "IdCtDienThoai");

            migrationBuilder.AddForeignKey(
                name: "FK_IMEI_CtDienThoai",
                table: "IMEI",
                column: "IdCtDienThoai",
                principalTable: "CtDienThoai",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IMEI_CtDienThoai",
                table: "IMEI");

            migrationBuilder.DropIndex(
                name: "IX_IMEI_IdCtDienThoai",
                table: "IMEI");

            migrationBuilder.DropColumn(
                name: "IdCtDienThoai",
                table: "IMEI");

            migrationBuilder.CreateIndex(
                name: "IX_IMEI_IdHoaDonChiTiet",
                table: "IMEI",
                column: "IdHoaDonChiTiet");

            migrationBuilder.AddForeignKey(
                name: "FK_IMEI_HoaDonChiTiet",
                table: "IMEI",
                column: "IdHoaDonChiTiet",
                principalTable: "HoaDonChiTiet",
                principalColumn: "Id");
        }
    }
}
