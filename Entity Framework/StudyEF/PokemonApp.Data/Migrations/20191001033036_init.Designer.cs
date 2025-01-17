﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonApp.Data;

namespace PokemonApp.Data.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20191001033036_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PokemonApp.Domain.Battle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("PokemonApp.Domain.Note", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PokemonID");

                    b.Property<string>("Text");

                    b.HasKey("ID");

                    b.HasIndex("PokemonID");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("PokemonApp.Domain.Pokemon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BattleID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("BattleID");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonApp.Domain.Note", b =>
                {
                    b.HasOne("PokemonApp.Domain.Pokemon", "Pokemon")
                        .WithMany("Notes")
                        .HasForeignKey("PokemonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PokemonApp.Domain.Pokemon", b =>
                {
                    b.HasOne("PokemonApp.Domain.Battle")
                        .WithMany("Pokemons")
                        .HasForeignKey("BattleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
