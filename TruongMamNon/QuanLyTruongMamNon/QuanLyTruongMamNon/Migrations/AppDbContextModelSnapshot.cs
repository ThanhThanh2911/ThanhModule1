﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyTruongMamNon.Models;

namespace QuanLyTruongMamNon.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLyTruongMamNon.Models.Children", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhuHuynhId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhuHuynhId")
                        .IsUnique();

                    b.ToTable("Childrens");
                });

            modelBuilder.Entity("QuanLyTruongMamNon.Models.ChildrenDiemDanh", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<int>("DiemDanhId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayId")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Time")
                        .HasColumnType("bit");

                    b.HasKey("ChildrenId", "DiemDanhId", "NgayId");

                    b.HasIndex("DiemDanhId");

                    b.ToTable("ChildrenDiemDanhs");
                });

            modelBuilder.Entity("QuanLyTruongMamNon.Models.DiemDanh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Afternoon")
                        .HasColumnType("bit");

                    b.Property<bool>("Morning")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DiemDanhs");
                });

            modelBuilder.Entity("QuanLyTruongMamNon.Models.PhuHuynh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhuHuynh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhuHuynhs");
                });

            modelBuilder.Entity("QuanLyTruongMamNon.Models.Children", b =>
                {
                    b.HasOne("QuanLyTruongMamNon.Models.PhuHuynh", "PhuHuynh")
                        .WithOne("Children")
                        .HasForeignKey("QuanLyTruongMamNon.Models.Children", "PhuHuynhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuanLyTruongMamNon.Models.ChildrenDiemDanh", b =>
                {
                    b.HasOne("QuanLyTruongMamNon.Models.Children", "Children")
                        .WithMany("DiemDanhs")
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyTruongMamNon.Models.DiemDanh", "DiemDanh")
                        .WithMany("Childrens")
                        .HasForeignKey("DiemDanhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
