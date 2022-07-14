using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXC.API.Migrations
{
    public partial class DataSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepatureTime", "Description", "DiscountPercentage", "Feature", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"), new DateTime(2022, 7, 10, 10, 43, 7, 109, DateTimeKind.Utc).AddTicks(1572), null, "华山一日游", null, "<p>吃住行购物<p>", "<p>交通费自理<p>", "<p>小心危险<p>", 1299m, "华山", null },
                    { new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"), new DateTime(2022, 7, 10, 10, 43, 7, 109, DateTimeKind.Utc).AddTicks(1653), null, "华山一日游", null, "<p>吃住行购物<p>", "<p>交通费自理<p>", "<p>小心危险<p>", 1299m, "华山", null }
                });

            migrationBuilder.InsertData(
                table: "TouristRoutePictures",
                columns: new[] { "Id", "TouristRouteId", "Url" },
                values: new object[,]
                {
                    { 5, new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"), "www.image.com/10d318ad-e39c-4b8f-baa3-858431affc67.jpg" },
                    { 6, new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"), "www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg" },
                    { 7, new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"), "www.image.com/50d318ad-e39c-4b8f-baa3-858431affc67.jpg" },
                    { 8, new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"), "www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 34, 24, 73, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 34, 24, 71, DateTimeKind.Utc).AddTicks(8935));
        }
    }
}
