using Microsoft.EntityFrameworkCore.Migrations;

namespace QLSV.Migrations
{
    public partial class fixFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiemCK",
                table: "LopHocPhan");

            migrationBuilder.DropColumn(
                name: "DiemGK",
                table: "LopHocPhan");

            migrationBuilder.AddColumn<double>(
                name: "DiemCK",
                table: "SinhVien",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DiemGK",
                table: "SinhVien",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiemCK",
                table: "SinhVien");

            migrationBuilder.DropColumn(
                name: "DiemGK",
                table: "SinhVien");

            migrationBuilder.AddColumn<double>(
                name: "DiemCK",
                table: "LopHocPhan",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DiemGK",
                table: "LopHocPhan",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
