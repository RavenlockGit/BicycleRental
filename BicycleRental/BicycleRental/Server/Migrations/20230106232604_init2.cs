using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleRental.Server.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "Region", "TireSize", "Type" },
                values: new object[] { "ipsum-fugit-ex", 2096956364, "Trent", "North Landen", 8.5891312168043026, "Cambridgeshire", 27, 6 });

            migrationBuilder.InsertData(
                table: "Bicycle",
                columns: new[] { "Id", "Brand", "FrontPicture", "GearCount", "Name", "Picture2", "Picture3", "Picture4", "Place", "PrizePerDay", "Region", "TireSize", "Type" },
                values: new object[,]
                {
                    { 2, "veniam-distinctio-non", null, -325212419, "Joaquin", null, null, null, "Howeview", 152.33187277249792, "Bedfordshire", 24, 4 },
                    { 3, "facilis-et-fuga", null, -1477872269, "Mose", null, null, null, "Lake Arturochester", 203.00585808804587, "Borders", 19, 0 },
                    { 4, "sit-optio-blanditiis", null, 1132901734, "Daphne", null, null, null, "Cassinshire", 234.13790180195451, "Borders", 13, 2 },
                    { 5, "nisi-dicta-sit", null, -84335275, "Amira", null, null, null, "Toyview", 229.34429108484181, "Bedfordshire", 28, 6 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "BicycleId", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 13, 31, 28, 829, DateTimeKind.Local).AddTicks(2617) },
                    { 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 23, 32, 3, 479, DateTimeKind.Local).AddTicks(4792) },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 17, 29, 3, 786, DateTimeKind.Local).AddTicks(380) },
                    { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 23, 54, 56, 573, DateTimeKind.Local).AddTicks(4852) },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 7, 38, 20, 175, DateTimeKind.Local).AddTicks(2866) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "Region", "TireSize", "Type" },
                values: new object[] { "sunt-reiciendis-quod", -1084683899, "William", "East Lethashire", 206.98628439470815, "Borders", 26, 3 });
        }
    }
}
