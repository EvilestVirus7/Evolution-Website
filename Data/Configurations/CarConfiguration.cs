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
                new Car() { CarId = 4, ImgPath = "/img/Super/EntityXF.png", Name = "Entity XF", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 5, ImgPath = "/img/Super/Infernus.png", Name = "Infernus", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 6, ImgPath = "/img/Super/Osiris.png", Name = "Osiris", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 7, ImgPath = "/img/Super/T20.png", Name = "T20", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 8, ImgPath = "/img/Super/TurismoR.png", Name = "Turismo R", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 9, ImgPath = "/img/Super/Vacca.png", Name = "Vacca", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 10, ImgPath = "/img/Super/Voltic.png", Name = "Voltic", Price = 0, MSRP = 0, Type = "Super" },
                new Car() { CarId = 11, ImgPath = "/img/Super/Zentorno.png", Name = "Voltic", Price = 0, MSRP = 0, Type = "Super" },

                //Sport
                new Car() { CarId = 12, ImgPath = "/img/Sport/9F.png", Name = "9F", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 13, ImgPath = "/img/Sport/9FCabrio.png", Name = "9F Cabrio", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 14, ImgPath = "/img/Sport/Alpha.png", Name = "Alpha", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 15, ImgPath = "/img/Sport/Banshee.png", Name = "Banshee", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 16, ImgPath = "/img/Sport/BlistaCompact.png", Name = "Blista Compact", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 17, ImgPath = "/img/Sport/GoGoMonkeyBlista.png", Name = "Monkey Blista", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 18, ImgPath = "/img/Sport/Buffalo.png", Name = "Buffalo", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 19, ImgPath = "/img/Sport/BuffaloS.png", Name = "Buffalo S", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 20, ImgPath = "/img/Sport/SprunkBuffalo.png", Name = "Sprunk Buffalo", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 21, ImgPath = "/img/Sport/Carbonizzare.png", Name = "Carbonizzare", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 22, ImgPath = "/img/Sport/Comet.png", Name = "Comet", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 23, ImgPath = "/img/Sport/Coquette.png", Name = "Coquette", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 24, ImgPath = "/img/Sport/ElegyRH8.png", Name = "Elegy RH8", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 25, ImgPath = "/img/Sport/Feltzer.png", Name = "Feltzer", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 26, ImgPath = "/img/Sport/FuroreGT.png", Name = "Furore GT", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 27, ImgPath = "/img/Sport/Fusilade.png", Name = "Fusilade", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 28, ImgPath = "/img/Sport/Futo.png", Name = "Futo", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 29, ImgPath = "/img/Sport/Jester.png", Name = "Jester", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 30, ImgPath = "/img/Sport/Jesterdecourse.png", Name = "Jester 2", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 31, ImgPath = "/img/Sport/Massacro.png", Name = "Massacro", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 32, ImgPath = "/img/Sport/Massacrodecourse.png", Name = "Massacro 2", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 33, ImgPath = "/img/Sport/Penumbra.png", Name = "Penumbra", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 34, ImgPath = "/img/Sport/RapidGT.png", Name = "Rapid GT", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 35, ImgPath = "/img/Sport/Schwartzer.png", Name = "Schwartzer", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 36, ImgPath = "/img/Sport/Sultan.png", Name = "Sultan", Price = 0, MSRP = 0, Type = "Sport" },
                new Car() { CarId = 37, ImgPath = "/img/Sport/Surano.png", Name = "Surano", Price = 0, MSRP = 0, Type = "Sport" },
                
                //SPORT CLASSIC
                new Car() { CarId = 38, ImgPath = "/img/SportClassics/CoquetteClassic.png", Name = "Coquette Ci", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 39, ImgPath = "/img/SportClassics/JB700.png", Name = "JB700", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 40, ImgPath = "/img/SportClassics/Manana.png", Name = "Manana", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 41, ImgPath = "/img/SportClassics/Monroe.png", Name = "Monroe", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 42, ImgPath = "/img/SportClassics/Peyote.png", Name = "Peyote", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 43, ImgPath = "/img/SportClassics/Pigalle.png", Name = "Pigalle", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 44, ImgPath = "/img/SportClassics/Roosevelt.png", Name = "Roosevelt", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 45, ImgPath = "/img/SportClassics/Stinger.png", Name = "Stinger", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 46, ImgPath = "/img/SportClassics/StirlingGT.png", Name = "Stirling GT", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 47, ImgPath = "/img/SportClassics/Tornado.png", Name = "Tornado", Price = 0, MSRP = 0, Type = "SportClassics" },
                new Car() { CarId = 48, ImgPath = "/img/SportClassics/Z-Type.png", Name = "Z-Type", Price = 0, MSRP = 0, Type = "SportClassics" },

                //Sedans
                new Car() { CarId = 49, ImgPath = "/img/Sedans/Asea.png", Name = "Asea", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 50, ImgPath = "/img/Sedans/Asterope.png", Name = "Asterope", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 51, ImgPath = "/img/Sedans/Emperor.png", Name = "Emperor", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 52, ImgPath = "/img/Sedans/Fugitive.png", Name = "Fugitive", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 53, ImgPath = "/img/Sedans/Glendale.png", Name = "Glendale", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 54, ImgPath = "/img/Sedans/Ingot.png", Name = "Ingot", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 55, ImgPath = "/img/Sedans/Intruder.png", Name = "Intruder", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 56, ImgPath = "/img/Sedans/Premier.png", Name = "Premier ", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 57, ImgPath = "/img/Sedans/Primo.png", Name = "Primo", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 58, ImgPath = "/img/Sedans/Regina.png", Name = "Premier", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 59, ImgPath = "/img/Sedans/RomeroHearse.png", Name = "Romero Hearse", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 60, ImgPath = "/img/Sedans/Schafter.png", Name = "Schafter", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 61, ImgPath = "/img/Sedans/Stanier.png", Name = "Stanier", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 62, ImgPath = "/img/Sedans/Stratum.png", Name = "Stratum", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 63, ImgPath = "/img/Sedans/Stretch.png", Name = "Stretch", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 64, ImgPath = "/img/Sedans/SuperDiamond.png", Name = "Super Diamond", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 65, ImgPath = "/img/Sedans/Surge.png", Name = "Surge", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 66, ImgPath = "/img/Sedans/Tailgater.png", Name = "Tailgater", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 67, ImgPath = "/img/Sedans/Warrener.png", Name = "Warrener", Price = 0, MSRP = 0, Type = "Sedans" },
                new Car() { CarId = 68, ImgPath = "/img/Sedans/Washington.png", Name = "Washington", Price = 0, MSRP = 0, Type = "Sedans" },

                //Muscles
                new Car() { CarId = 69, ImgPath = "/img/Muscle/Blade.png", Name = "Blade", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 70, ImgPath = "/img/Muscle/Buccaneer.png", Name = "Buccaneer", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 71, ImgPath = "/img/Muscle/Chino.png", Name = "Chino", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 72, ImgPath = "/img/Muscle/CoquetteBlackFin.png", Name = "Coquette BF", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 73, ImgPath = "/img/Muscle/Dominator.png", Name = "Dominator", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 74, ImgPath = "/img/Muscle/PisswasserDominator.png", Name = "Dominator 2", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 75, ImgPath = "/img/Muscle/Dukes.png", Name = "Dukes", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 76, ImgPath = "/img/Muscle/Gauntlet.png", Name = "Gauntlet", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 77, ImgPath = "/img/Muscle/RedwoodGauntlet.png", Name = "Gauntlet 2", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 78, ImgPath = "/img/Muscle/Hotknife.png", Name = "Hotknife", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 79, ImgPath = "/img/Muscle/Phoenix.png", Name = "Phoenix", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 80, ImgPath = "/img/Muscle/Picador.png", Name = "Picador", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 81, ImgPath = "/img/Muscle/Rat-Loader.png", Name = "Rat-Loader", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 82, ImgPath = "/img/Muscle/Rat-Truck.png", Name = "Rat-Truck", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 83, ImgPath = "/img/Muscle/Ruiner.png", Name = "Ruiner", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 84, ImgPath = "/img/Muscle/SabreTurbo.png", Name = "SabreTurbo", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 85, ImgPath = "/img/Muscle/Slamvan.png", Name = "Slamvan", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 86, ImgPath = "/img/Muscle/Stallion.png", Name = "Stallion", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 87, ImgPath = "/img/Muscle/BurgerShotStallion.png", Name = "BS Stallion", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 88, ImgPath = "/img/Muscle/Vigero.png", Name = "Vigero", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 89, ImgPath = "/img/Muscle/Virgo.png", Name = "Virgo", Price = 0, MSRP = 0, Type = "Muscle" },
                new Car() { CarId = 90, ImgPath = "/img/Muscle/Voodoo.png", Name = "Voodoo", Price = 0, MSRP = 0, Type = "Muscle" },

                //Coupes

                new Car() { CarId = 91, ImgPath = "/img/Coupes/CognoscentiCabrio.png", Name = "Cognoscenti", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 92, ImgPath = "/img/Coupes/Exemplar.png", Name = "Exemplar", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 93, ImgPath = "/img/Coupes/F620.png", Name = "F620", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 94, ImgPath = "/img/Coupes/Felon.png", Name = "Felon", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 95, ImgPath = "/img/Coupes/FelonGT.png", Name = "Felon GT", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 96, ImgPath = "/img/Coupes/Jackal.png", Name = "Jackal", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 97, ImgPath = "/img/Coupes/Oracle.png", Name = "Oracle", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 98, ImgPath = "/img/Coupes/OracleXS.png", Name = "Oracle XS", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 99, ImgPath = "/img/Coupes/Sentinel.png", Name = "Sentinel", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 100, ImgPath = "/img/Coupes/SentinelXS.png", Name = "Sentinel XS", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 101, ImgPath = "/img/Coupes/Windsor.png", Name = "Windsor", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 102, ImgPath = "/img/Coupes/Zion.png", Name = "Zion", Price = 0, MSRP = 0, Type = "Coupe" },
                new Car() { CarId = 103, ImgPath = "/img/Coupes/ZionCabrio.png", Name = "ZionCabrio", Price = 0, MSRP = 0, Type = "Coupe" },

                //Compacts
                new Car() { CarId = 104, ImgPath = "/img/Compacts/Blista.png", Name = "Blista", Price = 0, MSRP = 0, Type = "Compact" },
                new Car() { CarId = 105, ImgPath = "/img/Compacts/Dilettante.png", Name = "Dilettante", Price = 0, MSRP = 0, Type = "Compact" },
                new Car() { CarId = 106, ImgPath = "/img/Compacts/Issi.png", Name = "Issi", Price = 0, MSRP = 0, Type = "Compact" },
                new Car() { CarId = 107, ImgPath = "/img/Compacts/Panto.png", Name = "Panto", Price = 0, MSRP = 0, Type = "Compact" },
                new Car() { CarId = 108, ImgPath = "/img/Compacts/Prairie.png", Name = "Prairie", Price = 0, MSRP = 0, Type = "Compact" },
                new Car() { CarId = 109, ImgPath = "/img/Compacts/Rhapsody.png", Name = "Rhapsody", Price = 0, MSRP = 0, Type = "Compact" },

                //SUVs
                new Car() { CarId = 110, ImgPath = "/img/SUVs/Baller.png", Name = "Baller", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 111, ImgPath = "/img/SUVs/Baller2.png", Name = "Baller2", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 112, ImgPath = "/img/SUVs/BeeJayXL.png", Name = "BeeJay XL", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 113, ImgPath = "/img/SUVs/Cavalcade.png", Name = "Cavalcade", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 114, ImgPath = "/img/SUVs/Cavalcade2.png", Name = "Cavalcade 2", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 115, ImgPath = "/img/SUVs/Dubsta.png", Name = "Dubsta", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 116, ImgPath = "/img/SUVs/Dubsta2.png", Name = "Dubsta2", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 117, ImgPath = "/img/SUVs/FQ2.png", Name = "FQ2", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 118, ImgPath = "/img/SUVs/Granger.png", Name = "Granger", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 119, ImgPath = "/img/SUVs/Gresley.png", Name = "Gresley", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 120, ImgPath = "/img/SUVs/Habanero.png", Name = "Habanero", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 121, ImgPath = "/img/SUVs/HuntleyS.png", Name = "Huntley S", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 122, ImgPath = "/img/SUVs/Landstalker.png", Name = "Landstalker", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 123, ImgPath = "/img/SUVs/Mesa.png", Name = "Mesa", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 124, ImgPath = "/img/SUVs/Mesa3.png", Name = "Mesa 3", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 125, ImgPath = "/img/SUVs/Patriot.png", Name = "Patriot", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 126, ImgPath = "/img/SUVs/Radius.png", Name = "Radius", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 127, ImgPath = "/img/SUVs/Rocoto.png", Name = "Rocoto", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 128, ImgPath = "/img/SUVs/Seminole.png", Name = "Seminole", Price = 0, MSRP = 0, Type = "SUV" },
                new Car() { CarId = 129, ImgPath = "/img/SUVs/Serrano.png", Name = "Serrano", Price = 0, MSRP = 0, Type = "SUV" },

                //Vans
                new Car() { CarId = 130, ImgPath = "/img/Vans/Bison.png", Name = "Bison", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 131, ImgPath = "/img/Vans/Bison2.png", Name = "Bison2", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 132, ImgPath = "/img/Vans/Bison3.png", Name = "Bison3", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 133, ImgPath = "/img/Vans/BobcatXL.png", Name = "Bobcat XL", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 134, ImgPath = "/img/Vans/Boxville.png", Name = "Boxville", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 135, ImgPath = "/img/Vans/Boxville2.png", Name = "Boxville 2", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 136, ImgPath = "/img/Vans/Boxville3.png", Name = "Boxville 3", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 137, ImgPath = "/img/Vans/Burrito.png", Name = "Burrito", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 138, ImgPath = "/img/Vans/Camper.png", Name = "Camper", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 139, ImgPath = "/img/Vans/GangBurrito.png", Name = "Gang Burrito", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 140, ImgPath = "/img/Vans/GangBurrito2.png", Name = "Gang Burrito 2", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 141, ImgPath = "/img/Vans/Journey.png", Name = "Journey", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 142, ImgPath = "/img/Vans/Minivan.png", Name = "Minivan", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 143, ImgPath = "/img/Vans/Paradise.png", Name = "Paradise", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 144, ImgPath = "/img/Vans/Pony.png", Name = "Pony", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 145, ImgPath = "/img/Vans/Rumpo.png", Name = "Rumpo", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 146, ImgPath = "/img/Vans/Speedo.png", Name = "Speedo", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 147, ImgPath = "/img/Vans/Surfer.png", Name = "Surfer", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 148, ImgPath = "/img/Vans/Surfer2.png", Name = "Surfer 2", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 149, ImgPath = "/img/Vans/TacoVan.png", Name = "TacoVan", Price = 0, MSRP = 0, Type = "Van" },
                new Car() { CarId = 150, ImgPath = "/img/Vans/Youga.png", Name = "Youga", Price = 0, MSRP = 0, Type = "Van" },


                //Off-Road
                new Car() { CarId = 152, ImgPath = "/img/Off-Road/Bifta.png", Name = "Bifta", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 153, ImgPath = "/img/Off-Road/Blazer.png", Name = "Blazer", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 154, ImgPath = "/img/Off-Road/BlazerLifeguard.png", Name = "Blazer Lifeguard", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 155, ImgPath = "/img/Off-Road/Bodhi.png", Name = "Bodhi", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 156, ImgPath = "/img/Off-Road/Brawler.png", Name = "Brawler", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 157, ImgPath = "/img/Off-Road/Dubsta6x6.png", Name = "Dubsta 6x6", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 158, ImgPath = "/img/Off-Road/DuneBuggy.png", Name = "Dune Buggy", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 159, ImgPath = "/img/Off-Road/Duneloader.png", Name = "Duneloader", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 160, ImgPath = "/img/Off-Road/HotRodBlazer.png", Name = "Hot Rod Blazer", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 161, ImgPath = "/img/Off-Road/Injection.png", Name = "Injection", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 162, ImgPath = "/img/Off-Road/Kalahari.png", Name = "Kalahari", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 163, ImgPath = "/img/Off-Road/Marshall.png", Name = "Marshall", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 164, ImgPath = "/img/Off-Road/RancherXL.png", Name = "Rancher XL", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 165, ImgPath = "/img/Off-Road/Rebel.png", Name = "Rebel", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 166, ImgPath = "/img/Off-Road/RustyRebel.png", Name = "Rusty Rebel", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 167, ImgPath = "/img/Off-Road/SandkingXL.png", Name = "Sandking XL", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 168, ImgPath = "/img/Off-Road/SandkingSWB.png", Name = "Sandking SWB", Price = 0, MSRP = 0, Type = "Offroad" },
                new Car() { CarId = 169, ImgPath = "/img/Off-Road/Liberator.png", Name = "Liberator", Price = 0, MSRP = 0, Type = "Offroad" },

                //Moto
                new Car() { CarId = 170, ImgPath = "/img/Motorcycles/Akuma.png", Name = "Akuma", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 171, ImgPath = "/img/Motorcycles/Bagger.png", Name = "Bagger", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 172, ImgPath = "/img/Motorcycles/Bati801.png", Name = "Bati 801", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 173, ImgPath = "/img/Motorcycles/Bati801RR.png", Name = "Bati 801 RR", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 174, ImgPath = "/img/Motorcycles/CarbonRS.png", Name = "Carbon RS", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 175, ImgPath = "/img/Motorcycles/Daemon.png", Name = "Daemon", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 176, ImgPath = "/img/Motorcycles/DoubleT.png", Name = "Double T", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 177, ImgPath = "/img/Motorcycles/Faggio.png", Name = "Faggio", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 178, ImgPath = "/img/Motorcycles/Hakuchou.png", Name = "Hakuchou", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 179, ImgPath = "/img/Motorcycles/Hexer.png", Name = "Hexer", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 180, ImgPath = "/img/Motorcycles/Innovation.png", Name = "Innovation", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 181, ImgPath = "/img/Motorcycles/Nemesis.png", Name = "Nemesis", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 182, ImgPath = "/img/Motorcycles/PCJ600.png", Name = "PCJ600", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 183, ImgPath = "/img/Motorcycles/Ruffian.png", Name = "Ruffian", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 184, ImgPath = "/img/Motorcycles/Sanchez.png", Name = "Sanchez", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 185, ImgPath = "/img/Motorcycles/Sovereign.png", Name = "Sovereign", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 186, ImgPath = "/img/Motorcycles/Thrust.png", Name = "Thrust", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 187, ImgPath = "/img/Motorcycles/Vader.png", Name = "Vader", Price = 0, MSRP = 0, Type = "Moto" },
                new Car() { CarId = 188, ImgPath = "/img/Motorcycles/Vindicator.png", Name = "Vindicator", Price = 0, MSRP = 0, Type = "Moto" }
                );

                
        }

    }
}
