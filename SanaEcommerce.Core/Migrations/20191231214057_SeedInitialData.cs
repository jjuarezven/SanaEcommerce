using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SanaEcommerce.Core.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Electronics" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Garden" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Groceries" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Code", "CreationDate", "Name", "Price", "ProductCategoryCategoryId", "Stock", "UpdateDate" },
                values: new object[] { 1, 1, "001", new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Laptop", 500m, null, 66.0, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Code", "CreationDate", "Name", "Price", "ProductCategoryCategoryId", "Stock", "UpdateDate" },
                values: new object[] { 2, 1, "002", new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "TV", 300m, null, 20.0, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
