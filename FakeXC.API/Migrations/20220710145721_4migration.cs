using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXC.API.Migrations
{
    public partial class _4migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 14, 57, 21, 16, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 14, 57, 21, 16, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 14, 57, 21, 13, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 14, 57, 21, 16, DateTimeKind.Utc).AddTicks(5972));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 11, 0, 1, 507, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 11, 0, 1, 507, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 11, 0, 1, 505, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 11, 0, 1, 507, DateTimeKind.Utc).AddTicks(4631));
        }
    }
}
