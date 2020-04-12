using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class MergeMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FridayAvailability",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MondayAvailability",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredDays",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaturdayAvailability",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SundayAvailability",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThursdayAvailability",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TuesdayAvailability",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WednesdayAvailability",
                table: "Employees",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Day",
                columns: new[] { "Date", "DailyScheduleList" },
                values: new object[] { new DateTime(2020, 4, 12, 15, 43, 24, 854, DateTimeKind.Local).AddTicks(5754), "" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "d3e42805-9c97-43ed-a64c-fef72460787d", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "4ae30009-32c5-49a1-9bd2-9159e0f4a13f", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Day",
                keyColumn: "Date",
                keyValue: new DateTime(2020, 4, 12, 15, 43, 24, 854, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "4ae30009-32c5-49a1-9bd2-9159e0f4a13f");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "d3e42805-9c97-43ed-a64c-fef72460787d");

            migrationBuilder.DropColumn(
                name: "FridayAvailability",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MondayAvailability",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PreferredDays",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SaturdayAvailability",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SundayAvailability",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ThursdayAvailability",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TuesdayAvailability",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WednesdayAvailability",
                table: "Employees");

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
    }
}
