using Microsoft.EntityFrameworkCore.Migrations;

namespace EvoWebsite.Migrations
{
    public partial class AllCategorie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 38,
                column: "Name",
                value: "Coquette Ci");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 72,
                column: "Name",
                value: "Coquette BF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 74,
                column: "Name",
                value: "Dominator 2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 77,
                column: "Name",
                value: "Gauntlet 2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 91,
                column: "Name",
                value: "Cognoscenti");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 124,
                column: "Name",
                value: "Mesa 3");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImgPath", "MSRP", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 187, "/img/Motorcycles/Vader.png", 0.0, "Vader", 0.0, "Moto" },
                    { 164, "/img/Off-Road/RancherXL.png", 0.0, "Rancher XL", 0.0, "Offroad" },
                    { 165, "/img/Off-Road/Rebel.png", 0.0, "Rebel", 0.0, "Offroad" },
                    { 166, "/img/Off-Road/RustyRebel.png", 0.0, "Rusty Rebel", 0.0, "Offroad" },
                    { 167, "/img/Off-Road/SandkingXL.png", 0.0, "Sandking XL", 0.0, "Offroad" },
                    { 168, "/img/Off-Road/SandkingSWB.png", 0.0, "Sandking SWB", 0.0, "Offroad" },
                    { 169, "/img/Off-Road/Liberator.png", 0.0, "Liberator", 0.0, "Offroad" },
                    { 170, "/img/Motorcycles/Akuma.png", 0.0, "Akuma", 0.0, "Moto" },
                    { 171, "/img/Motorcycles/Bagger.png", 0.0, "Bagger", 0.0, "Moto" },
                    { 172, "/img/Motorcycles/Bati801.png", 0.0, "Bati 801", 0.0, "Moto" },
                    { 173, "/img/Motorcycles/Bati801RR.png", 0.0, "Bati 801 RR", 0.0, "Moto" },
                    { 174, "/img/Motorcycles/CarbonRS.png", 0.0, "Carbon RS", 0.0, "Moto" },
                    { 175, "/img/Motorcycles/Daemon.png", 0.0, "Daemon", 0.0, "Moto" },
                    { 176, "/img/Motorcycles/DoubleT.png", 0.0, "Double T", 0.0, "Moto" },
                    { 177, "/img/Motorcycles/Faggio.png", 0.0, "Faggio", 0.0, "Moto" },
                    { 163, "/img/Off-Road/Marshall.png", 0.0, "Marshall", 0.0, "Offroad" },
                    { 179, "/img/Motorcycles/Hexer.png", 0.0, "Hexer", 0.0, "Moto" },
                    { 180, "/img/Motorcycles/Innovation.png", 0.0, "Innovation", 0.0, "Moto" },
                    { 181, "/img/Motorcycles/Nemesis.png", 0.0, "Nemesis", 0.0, "Moto" },
                    { 182, "/img/Motorcycles/PCJ600.png", 0.0, "PCJ600", 0.0, "Moto" },
                    { 183, "/img/Motorcycles/Ruffian.png", 0.0, "Ruffian", 0.0, "Moto" },
                    { 184, "/img/Motorcycles/Sanchez.png", 0.0, "Sanchez", 0.0, "Moto" },
                    { 185, "/img/Motorcycles/Sovereign.png", 0.0, "Sovereign", 0.0, "Moto" },
                    { 186, "/img/Motorcycles/Thrust.png", 0.0, "Thrust", 0.0, "Moto" },
                    { 188, "/img/Motorcycles/Vindicator.png", 0.0, "Vindicator", 0.0, "Moto" },
                    { 178, "/img/Motorcycles/Hakuchou.png", 0.0, "Hakuchou", 0.0, "Moto" },
                    { 162, "/img/Off-Road/Kalahari.png", 0.0, "Kalahari", 0.0, "Offroad" },
                    { 160, "/img/Off-Road/HotRodBlazer.png", 0.0, "Hot Rod Blazer", 0.0, "Offroad" },
                    { 131, "/img/Vans/Bison2.png", 0.0, "Bison2", 0.0, "Van" },
                    { 132, "/img/Vans/Bison3.png", 0.0, "Bison3", 0.0, "Van" },
                    { 133, "/img/Vans/BobcatXL.png", 0.0, "Bobcat XL", 0.0, "Van" },
                    { 134, "/img/Vans/Boxville.png", 0.0, "Boxville", 0.0, "Van" },
                    { 135, "/img/Vans/Boxville2.png", 0.0, "Boxville 2", 0.0, "Van" },
                    { 136, "/img/Vans/Boxville3.png", 0.0, "Boxville 3", 0.0, "Van" },
                    { 137, "/img/Vans/Burrito.png", 0.0, "Burrito", 0.0, "Van" },
                    { 138, "/img/Vans/Camper.png", 0.0, "Camper", 0.0, "Van" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImgPath", "MSRP", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 139, "/img/Vans/GangBurrito.png", 0.0, "Gang Burrito", 0.0, "Van" },
                    { 140, "/img/Vans/GangBurrito2.png", 0.0, "Gang Burrito 2", 0.0, "Van" },
                    { 141, "/img/Vans/Journey.png", 0.0, "Journey", 0.0, "Van" },
                    { 142, "/img/Vans/Minivan.png", 0.0, "Minivan", 0.0, "Van" },
                    { 143, "/img/Vans/Paradise.png", 0.0, "Paradise", 0.0, "Van" },
                    { 144, "/img/Vans/Pony.png", 0.0, "Pony", 0.0, "Van" },
                    { 145, "/img/Vans/Rumpo.png", 0.0, "Rumpo", 0.0, "Van" },
                    { 146, "/img/Vans/Speedo.png", 0.0, "Speedo", 0.0, "Van" },
                    { 147, "/img/Vans/Surfer.png", 0.0, "Surfer", 0.0, "Van" },
                    { 148, "/img/Vans/Surfer2.png", 0.0, "Surfer 2", 0.0, "Van" },
                    { 149, "/img/Vans/TacoVan.png", 0.0, "TacoVan", 0.0, "Van" },
                    { 150, "/img/Vans/Youga.png", 0.0, "Youga", 0.0, "Van" },
                    { 151, "/img/Vans/BMX.png", 0.0, "BMX", 0.0, "Van" },
                    { 152, "/img/Off-Road/Bifta.png", 0.0, "Bifta", 0.0, "Offroad" },
                    { 153, "/img/Off-Road/Blazer.png", 0.0, "Blazer", 0.0, "Offroad" },
                    { 154, "/img/Off-Road/BlazerLifeguard.png", 0.0, "Blazer Lifeguard", 0.0, "Offroad" },
                    { 155, "/img/Off-Road/Bodhi.png", 0.0, "Bodhi", 0.0, "Offroad" },
                    { 156, "/img/Off-Road/Brawler.png", 0.0, "Brawler", 0.0, "Offroad" },
                    { 157, "/img/Off-Road/Dubsta6x6.png", 0.0, "Dubsta 6x6", 0.0, "Offroad" },
                    { 158, "/img/Off-Road/DuneBuggy.png", 0.0, "Dune Buggy", 0.0, "Offroad" },
                    { 159, "/img/Off-Road/Duneloader.png", 0.0, "Duneloader", 0.0, "Offroad" },
                    { 161, "/img/Off-Road/Injection.png", 0.0, "Injection", 0.0, "Offroad" },
                    { 130, "/img/Vans/Bison.png", 0.0, "Bison", 0.0, "Van" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 188);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 38,
                column: "Name",
                value: "Coquette Classic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 72,
                column: "Name",
                value: "Coquette BlackFin");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 74,
                column: "Name",
                value: "Pisswasser Dominator");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 77,
                column: "Name",
                value: "Redwood Gauntlet");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 91,
                column: "Name",
                value: "Cognoscenti Cabrio");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 124,
                column: "Name",
                value: "Mesa3");
        }
    }
}
