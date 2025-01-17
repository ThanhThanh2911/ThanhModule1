﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnePieceApp.Data;

namespace OnePieceApp.Data.Migrations
{
    [DbContext(typeof(OnePieceContext))]
    [Migration("20191003040321_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnePieceApp.Domain.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("ClanId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("OnePieceApp.Domain.Clan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("OnePieceApp.Domain.DevilFruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId");

                    b.Property<string>("Name");

                    b.Property<string>("Power");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("DevilFruits");
                });

            modelBuilder.Entity("OnePieceApp.Domain.Character", b =>
                {
                    b.HasOne("OnePieceApp.Domain.Clan")
                        .WithMany("Characters")
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnePieceApp.Domain.DevilFruit", b =>
                {
                    b.HasOne("OnePieceApp.Domain.Character", "Character")
                        .WithOne("DevilFruit")
                        .HasForeignKey("OnePieceApp.Domain.DevilFruit", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
