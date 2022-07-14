using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXC.API.Migrations
{
    public partial class DataSeeding3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepatureCity",
                table: "TouristRoutes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "TouristRoutes",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TravelDays",
                table: "TouristRoutes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripType",
                table: "TouristRoutes",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"),
                columns: new[] { "CreateTime", "DepatureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { new DateTime(2022, 7, 10, 11, 0, 1, 507, DateTimeKind.Utc).AddTicks(4559), 0, 3.0, 7, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                columns: new[] { "CreateTime", "DepatureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { new DateTime(2022, 7, 10, 11, 0, 1, 507, DateTimeKind.Utc).AddTicks(4389), 0, 3.0, 7, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                columns: new[] { "CreateTime", "DepatureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { new DateTime(2022, 7, 10, 11, 0, 1, 505, DateTimeKind.Utc).AddTicks(1492), 0, 4.0, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"),
                columns: new[] { "CreateTime", "DepatureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { new DateTime(2022, 7, 10, 11, 0, 1, 507, DateTimeKind.Utc).AddTicks(4631), 0, 3.0, 7, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepatureCity",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "TravelDays",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "TripType",
                table: "TouristRoutes");

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 43, 7, 109, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 43, 7, 109, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 43, 7, 106, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 43, 7, 109, DateTimeKind.Utc).AddTicks(1653));
        }
    }
}
