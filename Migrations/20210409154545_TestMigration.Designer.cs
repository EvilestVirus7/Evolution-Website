﻿// <auto-generated />
using EvoWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EvoWebsite.Migrations
{
    [DbContext(typeof(CarDbContext))]
    [Migration("20210409154545_TestMigration")]
    partial class TestMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("EvoWebsite.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MSRP")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            ImgPath = "/img/Super/Adder.png",
                            MSRP = 0.0,
                            Name = "Adder",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 2,
                            ImgPath = "/img/Super/Bullet.png",
                            MSRP = 0.0,
                            Name = "Bullet",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 3,
                            ImgPath = "/img/Super/Cheetah.png",
                            MSRP = 0.0,
                            Name = "Cheetah",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 4,
                            ImgPath = "/img/Super/EntityXF.png",
                            MSRP = 0.0,
                            Name = "EntityXF",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 5,
                            ImgPath = "/img/Super/Infernus.png",
                            MSRP = 0.0,
                            Name = "Infernus",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 6,
                            ImgPath = "/img/Super/Osiris.png",
                            MSRP = 0.0,
                            Name = "Osiris",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 7,
                            ImgPath = "/img/Super/T20.png",
                            MSRP = 0.0,
                            Name = "T20",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 8,
                            ImgPath = "/img/Super/TurismoR.png",
                            MSRP = 0.0,
                            Name = "TurismoR",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 9,
                            ImgPath = "/img/Super/Vacca.png",
                            MSRP = 0.0,
                            Name = "Vacca",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 10,
                            ImgPath = "/img/Super/Voltic.png",
                            MSRP = 0.0,
                            Name = "Voltic",
                            Price = 0.0
                        },
                        new
                        {
                            CarId = 11,
                            ImgPath = "/img/Super/Zentorno.png",
                            MSRP = 0.0,
                            Name = "Voltic",
                            Price = 0.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
