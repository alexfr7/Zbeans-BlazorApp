using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class OkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Day",
                columns: new[] { "Date", "DailyScheduleList" },
                values: new object[] { new DateTime(2020, 4, 12, 14, 48, 7, 566, DateTimeKind.Local).AddTicks(8142), "" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "ec12b9c4-5aac-47c7-bed9-ce66fdfd91c3", "Alex", "Frink", "Experienced" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "935023be-50b5-4a07-abc5-e66d8c0b6d04", "Nick", "Rogie", "Entry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Day",
                keyColumn: "Date",
                keyValue: new DateTime(2020, 4, 12, 14, 48, 7, 566, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "935023be-50b5-4a07-abc5-e66d8c0b6d04");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "ec12b9c4-5aac-47c7-bed9-ce66fdfd91c3");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "3f303ad2-8013-4835-af28-484507ebd23f", "Alex", "Frink", "Experienced" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "d2e84526-a739-4c71-9d02-0e07120ee7b8", "Nick", "Rogie", "Entry" });
        }
    }
}
