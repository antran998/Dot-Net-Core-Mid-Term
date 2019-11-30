using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLSV.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    Makhoa = table.Column<string>(nullable: false),
                    Tenkhoa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.Makhoa);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    Mamon = table.Column<string>(nullable: false),
                    Tenmon = table.Column<string>(nullable: true),
                    Sotinhi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.Mamon);
                });

            migrationBuilder.CreateTable(
                name: "LopHocPhan",
                columns: table => new
                {
                    MaLHP = table.Column<string>(nullable: false),
                    Namhoc = table.Column<string>(nullable: true),
                    Hocky = table.Column<string>(nullable: true),
                    Mon = table.Column<string>(nullable: true),
                    DiemGK = table.Column<double>(nullable: false),
                    DiemCK = table.Column<double>(nullable: false),
                    MonhocMamon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocPhan", x => x.MaLHP);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_MonHoc_MonhocMamon",
                        column: x => x.MonhocMamon,
                        principalTable: "MonHoc",
                        principalColumn: "Mamon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSV = table.Column<string>(nullable: false),
                    Hoten = table.Column<string>(nullable: true),
                    Ngaysinh = table.Column<DateTime>(nullable: false),
                    Dienthoai = table.Column<string>(nullable: true),
                    KhoaMakhoa = table.Column<string>(nullable: true),
                    LopHocPhanMaLHP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_SinhVien_Khoa_KhoaMakhoa",
                        column: x => x.KhoaMakhoa,
                        principalTable: "Khoa",
                        principalColumn: "Makhoa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SinhVien_LopHocPhan_LopHocPhanMaLHP",
                        column: x => x.LopHocPhanMaLHP,
                        principalTable: "LopHocPhan",
                        principalColumn: "MaLHP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_MonhocMamon",
                table: "LopHocPhan",
                column: "MonhocMamon");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_KhoaMakhoa",
                table: "SinhVien",
                column: "KhoaMakhoa");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_LopHocPhanMaLHP",
                table: "SinhVien",
                column: "LopHocPhanMaLHP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "Khoa");

            migrationBuilder.DropTable(
                name: "LopHocPhan");

            migrationBuilder.DropTable(
                name: "MonHoc");
        }
    }
}
