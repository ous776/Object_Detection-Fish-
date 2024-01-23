using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamRent.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc434640-8c20-4077-b0e1-43816430b259"));

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "Role", "UserName" },
                values: new object[] { new Guid("cc7527ce-beb1-4b1b-be2f-c09e2d612b2a"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc7527ce-beb1-4b1b-be2f-c09e2d612b2a"));

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[] { new Guid("dc434640-8c20-4077-b0e1-43816430b259"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin" });
        }
    }
}
