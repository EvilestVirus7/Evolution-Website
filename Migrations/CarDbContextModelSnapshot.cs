﻿// <auto-generated />
using EvoWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EvoWebsite.Migrations
{
    [DbContext(typeof(CarDbContext))]
    partial class CarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            ImgPath = "/img/Super/Adder.png",
                            MSRP = 0.0,
                            Name = "Adder",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 2,
                            ImgPath = "/img/Super/Bullet.png",
                            MSRP = 0.0,
                            Name = "Bullet",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 3,
                            ImgPath = "/img/Super/Cheetah.png",
                            MSRP = 0.0,
                            Name = "Cheetah",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 4,
                            ImgPath = "/img/Super/EntityXF.png",
                            MSRP = 0.0,
                            Name = "EntityXF",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 5,
                            ImgPath = "/img/Super/Infernus.png",
                            MSRP = 0.0,
                            Name = "Infernus",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 6,
                            ImgPath = "/img/Super/Osiris.png",
                            MSRP = 0.0,
                            Name = "Osiris",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 7,
                            ImgPath = "/img/Super/T20.png",
                            MSRP = 0.0,
                            Name = "T20",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 8,
                            ImgPath = "/img/Super/TurismoR.png",
                            MSRP = 0.0,
                            Name = "TurismoR",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 9,
                            ImgPath = "/img/Super/Vacca.png",
                            MSRP = 0.0,
                            Name = "Vacca",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 10,
                            ImgPath = "/img/Super/Voltic.png",
                            MSRP = 0.0,
                            Name = "Voltic",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 11,
                            ImgPath = "/img/Super/Zentorno.png",
                            MSRP = 0.0,
                            Name = "Voltic",
                            Price = 0.0,
                            Type = "Super"
                        },
                        new
                        {
                            CarId = 12,
                            ImgPath = "/img/Sport/9F.png",
                            MSRP = 0.0,
                            Name = "9F",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 13,
                            ImgPath = "/img/Sport/9FCabrio.png",
                            MSRP = 0.0,
                            Name = "9FCabrio",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 14,
                            ImgPath = "/img/Sport/Alpha.png",
                            MSRP = 0.0,
                            Name = "Alpha",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 15,
                            ImgPath = "/img/Sport/Banshee.png",
                            MSRP = 0.0,
                            Name = "Banshee",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 16,
                            ImgPath = "/img/Sport/BlistaCompact.png",
                            MSRP = 0.0,
                            Name = "BlistaCompact",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 17,
                            ImgPath = "/img/Sport/GoGoMonkeyBlista.png",
                            MSRP = 0.0,
                            Name = "GoGoMonkeyBlista",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 18,
                            ImgPath = "/img/Sport/Buffalo.png",
                            MSRP = 0.0,
                            Name = "Buffalo",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 19,
                            ImgPath = "/img/Sport/BuffaloS.png",
                            MSRP = 0.0,
                            Name = "BuffaloS",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 20,
                            ImgPath = "/img/Sport/SprunkBuffalo.png",
                            MSRP = 0.0,
                            Name = "SprunkBuffalo",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 21,
                            ImgPath = "/img/Sport/Carbonizzare.png",
                            MSRP = 0.0,
                            Name = "Carbonizzare",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 22,
                            ImgPath = "/img/Sport/Comet.png",
                            MSRP = 0.0,
                            Name = "Comet",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 23,
                            ImgPath = "/img/Sport/Coquette.png",
                            MSRP = 0.0,
                            Name = "Coquette",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 24,
                            ImgPath = "/img/Sport/ElegyRH8.png",
                            MSRP = 0.0,
                            Name = "ElegyRH8",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 25,
                            ImgPath = "/img/Sport/Feltzer.png",
                            MSRP = 0.0,
                            Name = "Feltzer",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 26,
                            ImgPath = "/img/Sport/FuroreGT.png",
                            MSRP = 0.0,
                            Name = "FuroreGT",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 27,
                            ImgPath = "/img/Sport/Fusilade.png",
                            MSRP = 0.0,
                            Name = "Fusilade",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 28,
                            ImgPath = "/img/Sport/Futo.png",
                            MSRP = 0.0,
                            Name = "Futo",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 29,
                            ImgPath = "/img/Sport/Jester.png",
                            MSRP = 0.0,
                            Name = "Jester",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 30,
                            ImgPath = "/img/Sport/Jesterdecourse.png",
                            MSRP = 0.0,
                            Name = "Jesterdecourse",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 31,
                            ImgPath = "/img/Sport/Massacro.png",
                            MSRP = 0.0,
                            Name = "Massacro",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 32,
                            ImgPath = "/img/Sport/Massacrodecourse.png",
                            MSRP = 0.0,
                            Name = "Massacrodecourse",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 33,
                            ImgPath = "/img/Sport/Penumbra.png",
                            MSRP = 0.0,
                            Name = "Penumbra",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 34,
                            ImgPath = "/img/Sport/RapidGT.png",
                            MSRP = 0.0,
                            Name = "RapidGT",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 35,
                            ImgPath = "/img/Sport/Schwartzer.png",
                            MSRP = 0.0,
                            Name = "Schwartzer",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 36,
                            ImgPath = "/img/Sport/Sultan.png",
                            MSRP = 0.0,
                            Name = "Sultan",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 37,
                            ImgPath = "/img/Sport/Surano.png",
                            MSRP = 0.0,
                            Name = "Surano",
                            Price = 0.0,
                            Type = "Sport"
                        },
                        new
                        {
                            CarId = 38,
                            ImgPath = "/img/SportClassics/CoquetteClassic.png",
                            MSRP = 0.0,
                            Name = "CoquetteClassic",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 39,
                            ImgPath = "/img/SportClassics/JB700.png",
                            MSRP = 0.0,
                            Name = "JB700",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 40,
                            ImgPath = "/img/SportClassics/Manana.png",
                            MSRP = 0.0,
                            Name = "Manana",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 41,
                            ImgPath = "/img/SportClassics/Monroe.png",
                            MSRP = 0.0,
                            Name = "Monroe",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 42,
                            ImgPath = "/img/SportClassics/Peyote.png",
                            MSRP = 0.0,
                            Name = "Peyote",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 43,
                            ImgPath = "/img/SportClassics/Pigalle.png",
                            MSRP = 0.0,
                            Name = "Pigalle",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 44,
                            ImgPath = "/img/SportClassics/Roosevelt.png",
                            MSRP = 0.0,
                            Name = "Roosevelt",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 45,
                            ImgPath = "/img/SportClassics/Stinger.png",
                            MSRP = 0.0,
                            Name = "Stinger",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 46,
                            ImgPath = "/img/SportClassics/StirlingGT.png",
                            MSRP = 0.0,
                            Name = "StirlingGT",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 47,
                            ImgPath = "/img/SportClassics/Tornado.png",
                            MSRP = 0.0,
                            Name = "Tornado",
                            Price = 0.0,
                            Type = "SportClassics"
                        },
                        new
                        {
                            CarId = 48,
                            ImgPath = "/img/SportClassics/Z-Type.png",
                            MSRP = 0.0,
                            Name = "Z-Type",
                            Price = 0.0,
                            Type = "SportClassics"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
