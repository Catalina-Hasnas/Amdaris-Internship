using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "CreatedAt", "Image", "Price", "PriceFormatted", "Title" },
                values: new object[,]
                {
                    { 1, 5, null, new DateTime(2021, 4, 28, 15, 43, 44, 44, DateTimeKind.Local).AddTicks(5870), "https://i.ibb.co/6bgccSg/212.jpg", 200, "200$", "First Product" },
                    { 2, 6, null, new DateTime(2021, 4, 28, 15, 43, 44, 46, DateTimeKind.Local).AddTicks(9835), "https://i.ibb.co/KyQwzHG/21133206.jpg", 210, "210$", "Second Product" },
                    { 3, 6, null, new DateTime(2021, 4, 28, 15, 43, 44, 46, DateTimeKind.Local).AddTicks(9867), "https://i.ibb.co/kmctC6G/21256508.jpg", 220, "220$", "Third Product" },
                    { 4, 6, null, new DateTime(2021, 4, 28, 15, 43, 44, 46, DateTimeKind.Local).AddTicks(9923), "https://i.ibb.co/KNFCs43/cosmetic-40.jpg", 220, "220$", "Fourth Product" },
                    { 5, 6, null, new DateTime(2021, 4, 28, 15, 43, 44, 46, DateTimeKind.Local).AddTicks(9927), "https://i.ibb.co/r6N7p8M/jar-03.jpg", 220, "220$", "Fifth Product" },
                    { 6, 6, null, new DateTime(2021, 4, 28, 15, 43, 44, 46, DateTimeKind.Local).AddTicks(9930), "https://i.ibb.co/X2gYjMN/jar-13.jpg", 220, "220$", "Sixth Product" },
                    { 7, 6, null, new DateTime(2021, 4, 28, 15, 43, 44, 46, DateTimeKind.Local).AddTicks(9934), "https://i.ibb.co/hcRbLBg/jar-24.jpg", 220, "220$", "Seventh Product" },
                    { 8, 6, null, new DateTime(2021, 4, 28, 15, 43, 44, 46, DateTimeKind.Local).AddTicks(9937), "https://i.ibb.co/mCMyJHD/jar-25.jpg", 220, "220$", "Eigth Product" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
