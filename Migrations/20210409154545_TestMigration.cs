using Microsoft.EntityFrameworkCore.Migrations;

namespace EvoWebsite.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MSRP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "ImgPath", "MSRP", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "/img/Super/Adder.png", 0.0, "Adder", 0.0 },
                    { 2, "/img/Super/Bullet.png", 0.0, "Bullet", 0.0 },
                    { 3, "/img/Super/Cheetah.png", 0.0, "Cheetah", 0.0 },
                    { 4, "/img/Super/EntityXF.png", 0.0, "EntityXF", 0.0 },
                    { 5, "/img/Super/Infernus.png", 0.0, "Infernus", 0.0 },
                    { 6, "/img/Super/Osiris.png", 0.0, "Osiris", 0.0 },
                    { 7, "/img/Super/T20.png", 0.0, "T20", 0.0 },
                    { 8, "/img/Super/TurismoR.png", 0.0, "TurismoR", 0.0 },
                    { 9, "/img/Super/Vacca.png", 0.0, "Vacca", 0.0 },
                    { 10, "/img/Super/Voltic.png", 0.0, "Voltic", 0.0 },
                    { 11, "/img/Super/Zentorno.png", 0.0, "Voltic", 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
