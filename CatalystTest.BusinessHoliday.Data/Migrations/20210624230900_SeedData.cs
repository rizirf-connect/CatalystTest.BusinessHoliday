using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalystTest.BusinessHoliday.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
