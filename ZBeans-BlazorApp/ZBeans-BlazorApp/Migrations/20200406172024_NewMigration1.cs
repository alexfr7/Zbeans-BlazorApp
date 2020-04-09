using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class NewMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "5f4a50a2-2ffe-4ab1-8267-3da3e44a4a36");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "d48cfe37-05b3-44f3-92f5-a7691a38c5f7");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "3f303ad2-8013-4835-af28-484507ebd23f", "Alex", "Frink", "Experienced" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "d2e84526-a739-4c71-9d02-0e07120ee7b8", "Nick", "Rogie", "Entry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "3f303ad2-8013-4835-af28-484507ebd23f");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "d2e84526-a739-4c71-9d02-0e07120ee7b8");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "d48cfe37-05b3-44f3-92f5-a7691a38c5f7", "Alex", "Frink", "Experienced" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "5f4a50a2-2ffe-4ab1-8267-3da3e44a4a36", "Nick", "Rogie", "Entry" });
        }
    }
}
