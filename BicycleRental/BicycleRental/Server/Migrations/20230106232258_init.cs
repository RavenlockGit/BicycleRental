using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleRental.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bicycle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCount = table.Column<int>(type: "int", nullable: false),
                    TireSize = table.Column<int>(type: "int", nullable: false),
                    PrizePerDay = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    FrontPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Picture2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Picture3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Picture4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicycle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BicycleId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bicycle",
                columns: new[] { "Id", "Brand", "FrontPicture", "GearCount", "Name", "Picture2", "Picture3", "Picture4", "Place", "PrizePerDay", "Region", "TireSize", "Type" },
                values: new object[] { 1, "sunt-reiciendis-quod", null, -1084683899, "William", null, null, null, "East Lethashire", 206.98628439470815, "Borders", 26, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bicycle");

            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
