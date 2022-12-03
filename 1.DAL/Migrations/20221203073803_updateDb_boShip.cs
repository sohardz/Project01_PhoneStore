using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class updateDb_boShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayNhan",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "NgayShip",
                table: "HoaDon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayNhan",
                table: "HoaDon",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayShip",
                table: "HoaDon",
                type: "date",
                nullable: true);
        }
    }
}
