﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruongDaiHocApp.Data;

namespace TruongDaiHocApp.Data.Migrations
{
    [DbContext(typeof(TruongDaiHocContext))]
    [Migration("20191002020745_add_db")]
    partial class add_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TruongDaiHocApp.Domain.GiaoVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GioiTinh");

                    b.Property<string>("HoTenGV");

                    b.Property<DateTime>("NgaySinh");

                    b.HasKey("Id");

                    b.ToTable("GiaoViens");
                });

            modelBuilder.Entity("TruongDaiHocApp.Domain.GiaoVienMonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiaoVienId");

                    b.Property<int>("MonHocId");

                    b.Property<int?>("SinhVienId");

                    b.HasKey("Id");

                    b.HasIndex("SinhVienId");

                    b.ToTable("GiaoVienMonHocs");
                });

            modelBuilder.Entity("TruongDaiHocApp.Domain.Lop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLop");

                    b.HasKey("Id");

                    b.ToTable("Lops");
                });

            modelBuilder.Entity("TruongDaiHocApp.Domain.MonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenMonHoc");

                    b.HasKey("Id");

                    b.ToTable("MonHocs");
                });

            modelBuilder.Entity("TruongDaiHocApp.Domain.SinhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GioiTinh");

                    b.Property<string>("HoTenSV");

                    b.Property<int>("LopId");

                    b.Property<DateTime>("NgaySinh");

                    b.HasKey("Id");

                    b.ToTable("SinhViens");
                });

            modelBuilder.Entity("TruongDaiHocApp.Domain.GiaoVienMonHoc", b =>
                {
                    b.HasOne("TruongDaiHocApp.Domain.SinhVien")
                        .WithMany("GiaoVienMonHocs")
                        .HasForeignKey("SinhVienId");
                });
#pragma warning restore 612, 618
        }
    }
}
