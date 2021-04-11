using Microsoft.EntityFrameworkCore.Migrations;

namespace EvoWebsite.Migrations
{
    public partial class SedanMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Importes",
                columns: table => new
                {
                    ImporteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Importes", x => x.ImporteId);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImgPath", "MSRP", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 49, "/img/Sedans/Asea.png", 0.0, "Asea", 0.0, "Sedans" },
                    { 66, "/img/Sedans/Tailgater.png", 0.0, "Tailgater", 0.0, "Sedans" },
                    { 65, "/img/Sedans/Surge.png", 0.0, "Surge", 0.0, "Sedans" },
                    { 64, "/img/Sedans/SuperDiamond.png", 0.0, "SuperDiamond", 0.0, "Sedans" },
                    { 63, "/img/Sedans/Stretch.png", 0.0, "Stretch", 0.0, "Sedans" },
                    { 62, "/img/Sedans/Stratum.png", 0.0, "Stratum", 0.0, "Sedans" },
                    { 61, "/img/Sedans/Stanier.png", 0.0, "Stanier", 0.0, "Sedans" },
                    { 60, "/img/Sedans/Schafter.png", 0.0, "Schafter", 0.0, "Sedans" },
                    { 59, "/img/Sedans/RomeroHearse.png", 0.0, "RomeroHearse", 0.0, "Sedans" },
                    { 58, "/img/Sedans/Regina.png", 0.0, "Premier", 0.0, "Sedans" },
                    { 57, "/img/Sedans/Primo.png", 0.0, "Primo", 0.0, "Sedans" },
                    { 56, "/img/Sedans/Premier.png", 0.0, "Premier ", 0.0, "Sedans" },
                    { 55, "/img/Sedans/Intruder.png", 0.0, "Intruder", 0.0, "Sedans" },
                    { 54, "/img/Sedans/Ingot.png", 0.0, "Ingot", 0.0, "Sedans" },
                    { 53, "/img/Sedans/Glendale.png", 0.0, "Glendale", 0.0, "Sedans" },
                    { 52, "/img/Sedans/Fugitive.png", 0.0, "Fugitive", 0.0, "Sedans" },
                    { 51, "/img/Sedans/Emperor.png", 0.0, "Emperor", 0.0, "Sedans" },
                    { 50, "/img/Asterope/Asea.png", 0.0, "Asterope", 0.0, "Sedans" },
                    { 67, "/img/Sedans/Warrener.png", 0.0, "Warrener", 0.0, "Sedans" },
                    { 68, "/img/Sedans/Washington.png", 0.0, "Washington", 0.0, "Sedans" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Importes");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 68);
        }
    }
}
