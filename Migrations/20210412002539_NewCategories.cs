using Microsoft.EntityFrameworkCore.Migrations;

namespace EvoWebsite.Migrations
{
    public partial class NewCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Importes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "Name",
                value: "Entity XF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                column: "Name",
                value: "Turismo R");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                column: "Name",
                value: "9F Cabrio");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 16,
                column: "Name",
                value: "Blista Compact");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 17,
                column: "Name",
                value: "Monkey Blista");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 19,
                column: "Name",
                value: "Buffalo S");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 20,
                column: "Name",
                value: "Sprunk Buffalo");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 24,
                column: "Name",
                value: "Elegy RH8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 26,
                column: "Name",
                value: "Furore GT");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 30,
                column: "Name",
                value: "Jester 2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 32,
                column: "Name",
                value: "Massacro 2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 34,
                column: "Name",
                value: "Rapid GT");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 38,
                column: "Name",
                value: "Coquette Classic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 46,
                column: "Name",
                value: "Stirling GT");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 50,
                column: "ImgPath",
                value: "/img/Sedans/Asterope.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 59,
                column: "Name",
                value: "Romero Hearse");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 64,
                column: "Name",
                value: "Super Diamond");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImgPath", "MSRP", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 128, "/img/SUVs/Seminole.png", 0.0, "Seminole", 0.0, "SUV" },
                    { 109, "/img/Compacts/Rhapsody.png", 0.0, "Rhapsody", 0.0, "Compact" },
                    { 110, "/img/SUVs/Baller.png", 0.0, "Baller", 0.0, "SUV" },
                    { 111, "/img/SUVs/Baller2.png", 0.0, "Baller2", 0.0, "SUV" },
                    { 112, "/img/SUVs/BeeJayXL.png", 0.0, "BeeJay XL", 0.0, "SUV" },
                    { 113, "/img/SUVs/Cavalcade.png", 0.0, "Cavalcade", 0.0, "SUV" },
                    { 114, "/img/SUVs/Cavalcade2.png", 0.0, "Cavalcade 2", 0.0, "SUV" },
                    { 115, "/img/SUVs/Dubsta.png", 0.0, "Dubsta", 0.0, "SUV" },
                    { 116, "/img/SUVs/Dubsta2.png", 0.0, "Dubsta2", 0.0, "SUV" },
                    { 117, "/img/SUVs/FQ2.png", 0.0, "FQ2", 0.0, "SUV" },
                    { 118, "/img/SUVs/Granger.png", 0.0, "Granger", 0.0, "SUV" },
                    { 119, "/img/SUVs/Gresley.png", 0.0, "Gresley", 0.0, "SUV" },
                    { 120, "/img/SUVs/Habanero.png", 0.0, "Habanero", 0.0, "SUV" },
                    { 121, "/img/SUVs/HuntleyS.png", 0.0, "Huntley S", 0.0, "SUV" },
                    { 122, "/img/SUVs/Landstalker.png", 0.0, "Landstalker", 0.0, "SUV" },
                    { 123, "/img/SUVs/Mesa.png", 0.0, "Mesa", 0.0, "SUV" },
                    { 124, "/img/SUVs/Mesa3.png", 0.0, "Mesa3", 0.0, "SUV" },
                    { 125, "/img/SUVs/Patriot.png", 0.0, "Patriot", 0.0, "SUV" },
                    { 108, "/img/Compacts/Prairie.png", 0.0, "Prairie", 0.0, "Compact" },
                    { 127, "/img/SUVs/Rocoto.png", 0.0, "Rocoto", 0.0, "SUV" },
                    { 129, "/img/SUVs/Serrano.png", 0.0, "Serrano", 0.0, "SUV" },
                    { 126, "/img/SUVs/Radius.png", 0.0, "Radius", 0.0, "SUV" },
                    { 107, "/img/Compacts/Panto.png", 0.0, "Panto", 0.0, "Compact" },
                    { 105, "/img/Compacts/Dilettante.png", 0.0, "Dilettante", 0.0, "Compact" },
                    { 84, "/img/Muscle/SabreTurbo.png", 0.0, "SabreTurbo", 0.0, "Muscle" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImgPath", "MSRP", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 83, "/img/Muscle/Ruiner.png", 0.0, "Ruiner", 0.0, "Muscle" },
                    { 82, "/img/Muscle/Rat-Truck.png", 0.0, "Rat-Truck", 0.0, "Muscle" },
                    { 81, "/img/Muscle/Rat-Loader.png", 0.0, "Rat-Loader", 0.0, "Muscle" },
                    { 80, "/img/Muscle/Picador.png", 0.0, "Picador", 0.0, "Muscle" },
                    { 79, "/img/Muscle/Phoenix.png", 0.0, "Phoenix", 0.0, "Muscle" },
                    { 78, "/img/Muscle/Hotknife.png", 0.0, "Hotknife", 0.0, "Muscle" },
                    { 77, "/img/Muscle/RedwoodGauntlet.png", 0.0, "Redwood Gauntlet", 0.0, "Muscle" },
                    { 76, "/img/Muscle/Gauntlet.png", 0.0, "Gauntlet", 0.0, "Muscle" },
                    { 75, "/img/Muscle/Dukes.png", 0.0, "Dukes", 0.0, "Muscle" },
                    { 74, "/img/Muscle/PisswasserDominator.png", 0.0, "Pisswasser Dominator", 0.0, "Muscle" },
                    { 73, "/img/Muscle/Dominator.png", 0.0, "Dominator", 0.0, "Muscle" },
                    { 72, "/img/Muscle/CoquetteBlackFin.png", 0.0, "Coquette BlackFin", 0.0, "Muscle" },
                    { 71, "/img/Muscle/Chino.png", 0.0, "Chino", 0.0, "Muscle" },
                    { 70, "/img/Muscle/Buccaneer.png", 0.0, "Buccaneer", 0.0, "Muscle" },
                    { 85, "/img/Muscle/Slamvan.png", 0.0, "Slamvan", 0.0, "Muscle" },
                    { 86, "/img/Muscle/Stallion.png", 0.0, "Stallion", 0.0, "Muscle" },
                    { 87, "/img/Muscle/BurgerShotStallion.png", 0.0, "BS Stallion", 0.0, "Muscle" },
                    { 88, "/img/Muscle/Vigero.png", 0.0, "Vigero", 0.0, "Muscle" },
                    { 104, "/img/Compacts/Blista.png", 0.0, "Blista", 0.0, "Compact" },
                    { 103, "/img/Coupes/ZionCabrio.png", 0.0, "ZionCabrio", 0.0, "Coupe" },
                    { 102, "/img/Coupes/Zion.png", 0.0, "Zion", 0.0, "Coupe" },
                    { 101, "/img/Coupes/Windsor.png", 0.0, "Windsor", 0.0, "Coupe" },
                    { 100, "/img/Coupes/SentinelXS.png", 0.0, "Sentinel XS", 0.0, "Coupe" },
                    { 99, "/img/Coupes/Sentinel.png", 0.0, "Sentinel", 0.0, "Coupe" },
                    { 98, "/img/Coupes/OracleXS.png", 0.0, "Oracle XS", 0.0, "Coupe" },
                    { 106, "/img/Compacts/Issi.png", 0.0, "Issi", 0.0, "Compact" },
                    { 97, "/img/Coupes/Oracle.png", 0.0, "Oracle", 0.0, "Coupe" },
                    { 95, "/img/Coupes/FelonGT.png", 0.0, "Felon GT", 0.0, "Coupe" },
                    { 94, "/img/Coupes/Felon.png", 0.0, "Felon", 0.0, "Coupe" },
                    { 93, "/img/Coupes/F620.png", 0.0, "F620", 0.0, "Coupe" },
                    { 92, "/img/Coupes/Exemplar.png", 0.0, "Exemplar", 0.0, "Coupe" },
                    { 91, "/img/Coupes/CognoscentiCabrio.png", 0.0, "Cognoscenti Cabrio", 0.0, "Coupe" },
                    { 90, "/img/Muscle/Voodoo.png", 0.0, "Voodoo", 0.0, "Muscle" },
                    { 89, "/img/Muscle/Virgo.png", 0.0, "Virgo", 0.0, "Muscle" },
                    { 96, "/img/Coupes/Jackal.png", 0.0, "Jackal", 0.0, "Coupe" },
                    { 69, "/img/Muscle/Blade.png", 0.0, "Blade", 0.0, "Muscle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 129);

            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Importes");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "Name",
                value: "EntityXF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                column: "Name",
                value: "TurismoR");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                column: "Name",
                value: "9FCabrio");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 16,
                column: "Name",
                value: "BlistaCompact");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 17,
                column: "Name",
                value: "GoGoMonkeyBlista");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 19,
                column: "Name",
                value: "BuffaloS");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 20,
                column: "Name",
                value: "SprunkBuffalo");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 24,
                column: "Name",
                value: "ElegyRH8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 26,
                column: "Name",
                value: "FuroreGT");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 30,
                column: "Name",
                value: "Jesterdecourse");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 32,
                column: "Name",
                value: "Massacrodecourse");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 34,
                column: "Name",
                value: "RapidGT");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 38,
                column: "Name",
                value: "CoquetteClassic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 46,
                column: "Name",
                value: "StirlingGT");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 50,
                column: "ImgPath",
                value: "/img/Asterope/Asea.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 59,
                column: "Name",
                value: "RomeroHearse");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 64,
                column: "Name",
                value: "SuperDiamond");
        }
    }
}
