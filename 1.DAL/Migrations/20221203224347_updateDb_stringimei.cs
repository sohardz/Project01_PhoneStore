using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class updateDb_stringimei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IMEI_MaIMEI",
                table: "IMEI");

            migrationBuilder.AlterColumn<string>(
                name: "MaIMEI",
                table: "IMEI",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_IMEI_MaIMEI",
                table: "IMEI",
                column: "MaIMEI",
                unique: true,
                filter: "[MaIMEI] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_IMEI_MaIMEI",
                table: "IMEI");

            migrationBuilder.AlterColumn<int>(
                name: "MaIMEI",
                table: "IMEI",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IMEI_MaIMEI",
                table: "IMEI",
                column: "MaIMEI",
                unique: true);
        }
    }
}
