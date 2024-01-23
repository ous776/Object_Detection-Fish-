using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamRent.Migrations
{
    /// <inheritdoc />
    public partial class _20230827 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d28002b-bc0d-4f6a-960a-9257b4809bc6"));

            migrationBuilder.DropColumn(
                name: "AnnualCost",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "DaylyCost",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "MonthlyCost",
                table: "Rentals",
                newName: "Cost");

            migrationBuilder.AddColumn<string>(
                name: "AssetNo",
                table: "Rentals",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[] { new Guid("dc75130c-04aa-4cda-a38e-f49302a63015"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc75130c-04aa-4cda-a38e-f49302a63015"));

            migrationBuilder.DropColumn(
                name: "AssetNo",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Rentals",
                newName: "MonthlyCost");

            migrationBuilder.AddColumn<double>(
                name: "AnnualCost",
                table: "Rentals",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DaylyCost",
                table: "Rentals",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[] { new Guid("7d28002b-bc0d-4f6a-960a-9257b4809bc6"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin" });
        }
    }
}
