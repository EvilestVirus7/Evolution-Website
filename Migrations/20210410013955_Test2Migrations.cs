using Microsoft.EntityFrameworkCore.Migrations;

namespace EvoWebsite.Migrations
{
    public partial class Test2Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImgPath", "MSRP", "Name", "Price" },
                values: new object[,]
                {
                    { 12, "/img/Sport/9F.png", 0.0, "9F", 0.0 },
                    { 32, "/img/Sport/Massacrodecourse.png", 0.0, "Massacrodecourse", 0.0 },
                    { 33, "/img/Sport/Penumbra.png", 0.0, "Penumbra", 0.0 },
                    { 34, "/img/Sport/RapidGT.png", 0.0, "RapidGT", 0.0 },
                    { 35, "/img/Sport/Schwartzer.png", 0.0, "Schwartzer", 0.0 },
                    { 36, "/img/Sport/Sultan.png", 0.0, "Sultan", 0.0 },
                    { 37, "/img/Sport/Surano.png", 0.0, "Surano", 0.0 },
                    { 38, "/img/SportClassics/CoquetteClassic.png", 0.0, "CoquetteClassic", 0.0 },
                    { 39, "/img/SportClassics/JB700.png", 0.0, "JB700", 0.0 },
                    { 40, "/img/SportClassics/Manana.png", 0.0, "Manana", 0.0 },
                    { 41, "/img/SportClassics/Monroe.png", 0.0, "Monroe", 0.0 },
                    { 42, "/img/SportClassics/Peyote.png", 0.0, "Peyote", 0.0 },
                    { 43, "/img/SportClassics/Pigalle.png", 0.0, "Pigalle", 0.0 },
                    { 44, "/img/SportClassics/Roosevelt.png", 0.0, "Roosevelt", 0.0 },
                    { 45, "/img/SportClassics/Stinger.png", 0.0, "Stinger", 0.0 },
                    { 46, "/img/SportClassics/StirlingGT.png", 0.0, "StirlingGT", 0.0 },
                    { 31, "/img/Sport/Massacro.png", 0.0, "Massacro", 0.0 },
                    { 47, "/img/SportClassics/Tornado.png", 0.0, "Tornado", 0.0 },
                    { 30, "/img/Sport/Jesterdecourse.png", 0.0, "Jesterdecourse", 0.0 },
                    { 28, "/img/Sport/Futo.png", 0.0, "Futo", 0.0 },
                    { 13, "/img/Sport/9FCabrio.png", 0.0, "9FCabrio", 0.0 },
                    { 14, "/img/Sport/Alpha.png", 0.0, "Alpha", 0.0 },
                    { 15, "/img/Sport/Banshee.png", 0.0, "Banshee", 0.0 },
                    { 16, "/img/Sport/BlistaCompact.png", 0.0, "BlistaCompact", 0.0 },
                    { 17, "/img/Sport/GoGoMonkeyBlista.png", 0.0, "GoGoMonkeyBlista", 0.0 },
                    { 18, "/img/Sport/Buffalo.png", 0.0, "Buffalo", 0.0 },
                    { 19, "/img/Sport/BuffaloS.png", 0.0, "BuffaloS", 0.0 },
                    { 20, "/img/Sport/SprunkBuffalo.png", 0.0, "SprunkBuffalo", 0.0 },
                    { 21, "/img/Sport/Carbonizzare.png", 0.0, "Carbonizzare", 0.0 },
                    { 22, "/img/Sport/Comet.png", 0.0, "Comet", 0.0 },
                    { 23, "/img/Sport/Coquette.png", 0.0, "Coquette", 0.0 },
                    { 24, "/img/Sport/ElegyRH8.png", 0.0, "ElegyRH8", 0.0 },
                    { 25, "/img/Sport/Feltzer.png", 0.0, "Feltzer", 0.0 },
                    { 26, "/img/Sport/FuroreGT.png", 0.0, "FuroreGT", 0.0 },
                    { 27, "/img/Sport/Fusilade.png", 0.0, "Fusilade", 0.0 },
                    { 29, "/img/Sport/Jester.png", 0.0, "Jester", 0.0 },
                    { 48, "/img/SportClassics/Z-Type.png", 0.0, "Z-Type", 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 48);
        }
    }
}
