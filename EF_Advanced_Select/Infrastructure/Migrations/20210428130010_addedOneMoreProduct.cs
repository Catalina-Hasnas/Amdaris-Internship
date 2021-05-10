using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addedOneMoreProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "CreatedAt", "Image", "Price", "PriceFormatted", "Title" },
                values: new object[] { 9, 6, null, new DateTime(2021, 4, 28, 16, 0, 9, 996, DateTimeKind.Local).AddTicks(2618), "https://i.ibb.co/qJVPFxJ/jar-36.jpg", 220, "220$", "Nineth Product" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
