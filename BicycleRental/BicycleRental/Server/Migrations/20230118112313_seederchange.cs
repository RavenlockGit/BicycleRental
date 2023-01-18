using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleRental.Server.Migrations
{
    public partial class seederchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "TireSize", "Type" },
                values: new object[] { "ratione-ea-quisquam", -1022928617, "Audreanne", "Oletashire", 3.1584989716117673, 19, 1 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "TireSize", "Type" },
                values: new object[] { "voluptatem-distinctio-sint", -303086298, "Marlin", "Haneland", 111.53173625572543, 12, 0 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "Region", "TireSize", "Type" },
                values: new object[] { "sunt-repellendus-et", -1629358854, "Allene", "East Pedro", 116.72240846101759, "Cambridgeshire", 24, 1 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "TireSize", "Type" },
                values: new object[] { "ut-eaque-quis", -1809174832, "Maybelle", "South Caterinafurt", 216.46388568906099, 11, 1 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "Region", "TireSize" },
                values: new object[] { "deserunt-est-rerum", 323397413, "Reed", "Jamaalton", 89.541930709620473, "Borders", 19 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 2, new DateTime(2023, 2, 6, 4, 35, 28, 740, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 1, 25, 5, 37, 6, 541, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 6, new DateTime(2023, 2, 6, 8, 1, 51, 587, DateTimeKind.Local).AddTicks(2022), new DateTime(2023, 1, 28, 0, 55, 40, 125, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 3, new DateTime(2023, 2, 3, 9, 49, 33, 548, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 1, 26, 5, 11, 35, 687, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 2, new DateTime(2023, 2, 2, 14, 13, 4, 195, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 1, 24, 5, 50, 29, 876, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 1, new DateTime(2023, 2, 1, 12, 27, 40, 132, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 1, 25, 19, 12, 45, 362, DateTimeKind.Local).AddTicks(56) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "TireSize", "Type" },
                values: new object[] { "ipsum-fugit-ex", 2096956364, "Trent", "North Landen", 8.5891312168043026, 27, 6 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "TireSize", "Type" },
                values: new object[] { "veniam-distinctio-non", -325212419, "Joaquin", "Howeview", 152.33187277249792, 24, 4 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "Region", "TireSize", "Type" },
                values: new object[] { "facilis-et-fuga", -1477872269, "Mose", "Lake Arturochester", 203.00585808804587, "Borders", 19, 0 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "TireSize", "Type" },
                values: new object[] { "sit-optio-blanditiis", 1132901734, "Daphne", "Cassinshire", 234.13790180195451, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Bicycle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "GearCount", "Name", "Place", "PrizePerDay", "Region", "TireSize" },
                values: new object[] { "nisi-dicta-sit", -84335275, "Amira", "Toyview", 229.34429108484181, "Bedfordshire", 28 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 13, 31, 28, 829, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 23, 32, 3, 479, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 17, 29, 3, 786, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 23, 54, 56, 573, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BicycleId", "EndDate", "StartDate" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 7, 38, 20, 175, DateTimeKind.Local).AddTicks(2866) });
        }
    }
}
