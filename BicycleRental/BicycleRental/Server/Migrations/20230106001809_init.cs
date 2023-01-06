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
                    PrizePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    FrontPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Picture2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Picture3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Picture4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicycle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bicycle");
        }
    }
}
