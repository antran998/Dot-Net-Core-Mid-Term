﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLSV.Models;

namespace QLSV.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191130020236_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QLSV.Models.Khoa", b =>
                {
                    b.Property<string>("Makhoa")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tenkhoa");

                    b.HasKey("Makhoa");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("QLSV.Models.LopHocPhan", b =>
                {
                    b.Property<string>("MaLHP")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("DiemCK");

                    b.Property<double>("DiemGK");

                    b.Property<string>("Hocky");

                    b.Property<string>("Mon");

                    b.Property<string>("MonhocMamon");

                    b.Property<string>("Namhoc");

                    b.HasKey("MaLHP");

                    b.HasIndex("MonhocMamon");

                    b.ToTable("LopHocPhan");
                });

            modelBuilder.Entity("QLSV.Models.MonHoc", b =>
                {
                    b.Property<string>("Mamon")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Sotinhi");

                    b.Property<string>("Tenmon");

                    b.HasKey("Mamon");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("QLSV.Models.SinhVien", b =>
                {
                    b.Property<string>("MaSV")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dienthoai");

                    b.Property<string>("Hoten");

                    b.Property<string>("KhoaMakhoa");

                    b.Property<string>("LopHocPhanMaLHP");

                    b.Property<DateTime>("Ngaysinh");

                    b.HasKey("MaSV");

                    b.HasIndex("KhoaMakhoa");

                    b.HasIndex("LopHocPhanMaLHP");

                    b.ToTable("SinhVien");
                });

            modelBuilder.Entity("QLSV.Models.LopHocPhan", b =>
                {
                    b.HasOne("QLSV.Models.MonHoc", "Monhoc")
                        .WithMany("Lophocphan")
                        .HasForeignKey("MonhocMamon");
                });

            modelBuilder.Entity("QLSV.Models.SinhVien", b =>
                {
                    b.HasOne("QLSV.Models.Khoa", "Khoa")
                        .WithMany("Sinhvien")
                        .HasForeignKey("KhoaMakhoa");

                    b.HasOne("QLSV.Models.LopHocPhan")
                        .WithMany("Sinhvien")
                        .HasForeignKey("LopHocPhanMaLHP");
                });
#pragma warning restore 612, 618
        }
    }
}
