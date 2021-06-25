using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalystTest.BusinessHoliday.Data.Migrations
{
    public partial class CorrectSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("0dea486b-c03a-4009-ae91-e5cac2f11cc5"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("3d5d5f17-ab62-46a7-859d-fefb9180e7f7"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("84fcd709-9474-4c97-9056-c83651e9dc7e"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("9a331011-7d94-47d4-9889-c69a281f2e8d"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("cd46d6ec-d58a-4ab4-904f-7ab87692a22b"));

            migrationBuilder.InsertData(
                table: "BusinessHoliday",
                columns: new[] { "BusinessHolidayId", "Active", "FromDate", "HolidayOccasion", "ToDate" },
                values: new object[,]
                {
                    { new Guid("be43fe5d-6647-4bbf-83cf-cec822a7c570"), true, new DateTime(2021, 6, 26, 20, 54, 14, 319, DateTimeKind.Local).AddTicks(4526), "EidUlAzha", new DateTime(2021, 6, 28, 20, 54, 14, 320, DateTimeKind.Local).AddTicks(4869) },
                    { new Guid("a61ed250-7a89-45cf-91b2-2176f4044262"), true, new DateTime(2021, 6, 30, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2881), "Eid", new DateTime(2021, 7, 3, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2898) },
                    { new Guid("f0eada24-824c-48ff-8e2d-ae71362de6a6"), true, new DateTime(2021, 7, 5, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2903), "Moharram", new DateTime(2021, 7, 6, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2904) },
                    { new Guid("74d55589-4c3c-43ea-aa73-f98e9a7b71a0"), true, new DateTime(2021, 7, 10, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2906), "Iqbal", new DateTime(2021, 7, 10, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2907) }
                });

            migrationBuilder.InsertData(
                table: "BusinessHoliday",
                columns: new[] { "BusinessHolidayId", "FromDate", "HolidayOccasion", "ToDate" },
                values: new object[] { new Guid("e26831d8-de38-49e6-a193-91443c74c5ce"), new DateTime(2021, 7, 15, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2909), "Christmas", new DateTime(2021, 7, 15, 20, 54, 14, 321, DateTimeKind.Local).AddTicks(2911) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("74d55589-4c3c-43ea-aa73-f98e9a7b71a0"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("a61ed250-7a89-45cf-91b2-2176f4044262"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("be43fe5d-6647-4bbf-83cf-cec822a7c570"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("e26831d8-de38-49e6-a193-91443c74c5ce"));

            migrationBuilder.DeleteData(
                table: "BusinessHoliday",
                keyColumn: "BusinessHolidayId",
                keyValue: new Guid("f0eada24-824c-48ff-8e2d-ae71362de6a6"));

            migrationBuilder.InsertData(
                table: "BusinessHoliday",
                columns: new[] { "BusinessHolidayId", "Active", "FromDate", "HolidayOccasion", "ToDate" },
                values: new object[,]
                {
                    { new Guid("cd46d6ec-d58a-4ab4-904f-7ab87692a22b"), true, new DateTime(2021, 6, 26, 4, 8, 59, 896, DateTimeKind.Local).AddTicks(5294), "EidUlAzha", new DateTime(2021, 6, 28, 4, 8, 59, 897, DateTimeKind.Local).AddTicks(6592) },
                    { new Guid("9a331011-7d94-47d4-9889-c69a281f2e8d"), true, new DateTime(2021, 6, 30, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(1988), "Eid", new DateTime(2021, 6, 28, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(2000) },
                    { new Guid("0dea486b-c03a-4009-ae91-e5cac2f11cc5"), true, new DateTime(2021, 7, 5, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(2006), "Moharram", new DateTime(2021, 6, 27, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(2008) },
                    { new Guid("84fcd709-9474-4c97-9056-c83651e9dc7e"), true, new DateTime(2021, 7, 10, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(2011), "Iqbal", new DateTime(2021, 6, 26, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(2013) }
                });

            migrationBuilder.InsertData(
                table: "BusinessHoliday",
                columns: new[] { "BusinessHolidayId", "FromDate", "HolidayOccasion", "ToDate" },
                values: new object[] { new Guid("3d5d5f17-ab62-46a7-859d-fefb9180e7f7"), new DateTime(2021, 7, 15, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(2016), "Christmas", new DateTime(2021, 6, 26, 4, 8, 59, 898, DateTimeKind.Local).AddTicks(2017) });
        }
    }
}
