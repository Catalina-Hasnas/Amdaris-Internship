using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addedCategoryToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2021, 4, 29, 13, 14, 21, 286, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 4, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 5, new DateTime(2021, 4, 29, 13, 14, 21, 289, DateTimeKind.Local).AddTicks(9658) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 466, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2021, 4, 29, 12, 24, 40, 473, DateTimeKind.Local).AddTicks(2987) });
        }
    }
}
