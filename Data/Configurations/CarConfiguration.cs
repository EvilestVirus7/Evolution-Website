using EvoWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {

            builder.HasData(

                //SUPER CARS
                new Car() { CarId = 1, ImgPath = "/img/Super/Adder.png", Name = "Adder", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 2, ImgPath = "/img/Super/Bullet.png", Name = "Bullet", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 3, ImgPath = "/img/Super/Cheetah.png", Name = "Cheetah", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 4, ImgPath = "/img/Super/EntityXF.png", Name = "EntityXF", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 5, ImgPath = "/img/Super/Infernus.png", Name = "Infernus", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 6, ImgPath = "/img/Super/Osiris.png", Name = "Osiris", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 7, ImgPath = "/img/Super/T20.png", Name = "T20", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 8, ImgPath = "/img/Super/TurismoR.png", Name = "TurismoR", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 9, ImgPath = "/img/Super/Vacca.png", Name = "Vacca", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 10, ImgPath = "/img/Super/Voltic.png", Name = "Voltic", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 11, ImgPath = "/img/Super/Zentorno.png", Name = "Voltic", Price = 0, MSRP = 0, Type = "Super" },


                new Car() { CarId = 12, ImgPath = "/img/Sport/9F.png", Name = "9F", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 13, ImgPath = "/img/Sport/9FCabrio.png", Name = "9FCabrio", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 14, ImgPath = "/img/Sport/Alpha.png", Name = "Alpha", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 15, ImgPath = "/img/Sport/Banshee.png", Name = "Banshee", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 16, ImgPath = "/img/Sport/BlistaCompact.png", Name = "BlistaCompact", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 17, ImgPath = "/img/Sport/GoGoMonkeyBlista.png", Name = "GoGoMonkeyBlista", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 18, ImgPath = "/img/Sport/Buffalo.png", Name = "Buffalo", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 19, ImgPath = "/img/Sport/BuffaloS.png", Name = "BuffaloS", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 20, ImgPath = "/img/Sport/SprunkBuffalo.png", Name = "SprunkBuffalo", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 21, ImgPath = "/img/Sport/Carbonizzare.png", Name = "Carbonizzare", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 22, ImgPath = "/img/Sport/Comet.png", Name = "Comet", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 23, ImgPath = "/img/Sport/Coquette.png", Name = "Coquette", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 24, ImgPath = "/img/Sport/ElegyRH8.png", Name = "ElegyRH8", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 25, ImgPath = "/img/Sport/Feltzer.png", Name = "Feltzer", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 26, ImgPath = "/img/Sport/FuroreGT.png", Name = "FuroreGT", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 27, ImgPath = "/img/Sport/Fusilade.png", Name = "Fusilade", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 28, ImgPath = "/img/Sport/Futo.png", Name = "Futo", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 29, ImgPath = "/img/Sport/Jester.png", Name = "Jester", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 30, ImgPath = "/img/Sport/Jesterdecourse.png", Name = "Jesterdecourse", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 31, ImgPath = "/img/Sport/Massacro.png", Name = "Massacro", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 32, ImgPath = "/img/Sport/Massacrodecourse.png", Name = "Massacrodecourse", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 33, ImgPath = "/img/Sport/Penumbra.png", Name = "Penumbra", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 34, ImgPath = "/img/Sport/RapidGT.png", Name = "RapidGT", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 35, ImgPath = "/img/Sport/Schwartzer.png", Name = "Schwartzer", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 36, ImgPath = "/img/Sport/Sultan.png", Name = "Sultan", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 37, ImgPath = "/img/Sport/Surano.png", Name = "Surano", Price = 0, MSRP = 0, Type = "Sport" },
                
                //SPORT CLASSIC
                new Car() { CarId = 38, ImgPath = "/img/SportClassics/CoquetteClassic.png", Name = "CoquetteClassic", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 39, ImgPath = "/img/SportClassics/JB700.png", Name = "JB700", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 40, ImgPath = "/img/SportClassics/Manana.png", Name = "Manana", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 41, ImgPath = "/img/SportClassics/Monroe.png", Name = "Monroe", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 42, ImgPath = "/img/SportClassics/Peyote.png", Name = "Peyote", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 43, ImgPath = "/img/SportClassics/Pigalle.png", Name = "Pigalle", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 44, ImgPath = "/img/SportClassics/Roosevelt.png", Name = "Roosevelt", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 45, ImgPath = "/img/SportClassics/Stinger.png", Name = "Stinger", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 46, ImgPath = "/img/SportClassics/StirlingGT.png", Name = "StirlingGT", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 47, ImgPath = "/img/SportClassics/Tornado.png", Name = "Tornado", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 48, ImgPath = "/img/SportClassics/Z-Type.png", Name = "Z-Type", Price = 0, MSRP = 0, Type = "SportClassics" }
            );
        }

    }
}
