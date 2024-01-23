using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamRent.Migrations
{
    /// <inheritdoc />
    public partial class _20230827_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc75130c-04aa-4cda-a38e-f49302a63015"));

            migrationBuilder.AddColumn<string>(
                name: "Num",
                table: "Tenants",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[] { new Guid("dc434640-8c20-4077-b0e1-43816430b259"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc434640-8c20-4077-b0e1-43816430b259"));

            migrationBuilder.DropColumn(
                name: "Num",
                table: "Tenants");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[] { new Guid("dc75130c-04aa-4cda-a38e-f49302a63015"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin" });
        }
    }
}
