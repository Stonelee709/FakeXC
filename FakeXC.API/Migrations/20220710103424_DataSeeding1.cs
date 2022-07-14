using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXC.API.Migrations
{
    public partial class DataSeeding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 34, 24, 71, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepatureTime", "Description", "DiscountPercentage", "Feature", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"), new DateTime(2022, 7, 10, 10, 34, 24, 73, DateTimeKind.Utc).AddTicks(9146), null, "华山一日游", null, "<p>吃住行购物<p>", "<p>交通费自理<p>", "<p>小心危险<p>", 1299m, "华山", null });

            migrationBuilder.InsertData(
                table: "TouristRoutePictures",
                columns: new[] { "Id", "TouristRouteId", "Url" },
                values: new object[] { 3, new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"), "www.image.com/20d318ad-e39c-4b8f-baa3-858431affc67.jpg" });

            migrationBuilder.InsertData(
                table: "TouristRoutePictures",
                columns: new[] { "Id", "TouristRouteId", "Url" },
                values: new object[] { 4, new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"), "www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"));

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 10, 10, 31, 40, 307, DateTimeKind.Utc).AddTicks(3128));
        }
    }
}
