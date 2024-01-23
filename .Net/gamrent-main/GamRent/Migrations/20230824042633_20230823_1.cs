using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamRent.Migrations
{
    /// <inheritdoc />
    public partial class _20230823_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3389300a-615a-4721-8e89-6b7bc13ec85b"));

            migrationBuilder.CreateTable(
                name: "RentalCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalCategories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[] { new Guid("7d28002b-bc0d-4f6a-960a-9257b4809bc6"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalCategories");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d28002b-bc0d-4f6a-960a-9257b4809bc6"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[] { new Guid("3389300a-615a-4721-8e89-6b7bc13ec85b"), "admin@gmail.com", "Admin", "Admin", "Admin Account", "pIbvhgmpVHahDBTYUgQvew==", "1234567", "admin" });
        }
    }
}
