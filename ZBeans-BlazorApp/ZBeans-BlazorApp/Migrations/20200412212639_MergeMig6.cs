using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class MergeMig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Day",
                keyColumn: "Date",
                keyValue: new DateTime(2020, 4, 12, 17, 6, 35, 166, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "a6bc572c-d2ed-4402-a1c5-9ee6bbb91c10");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "d97ea811-e404-4081-8a56-afa0aaf0a4ee");

            migrationBuilder.AddColumn<string>(
                name: "StoreSelect",
                table: "Day",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Day",
                columns: new[] { "Date", "DailyScheduleList", "RequiredEmployees", "StoreSelect" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "test" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "d81d414e-5268-40df-9bc6-527570bbc435", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "fcbdd6e6-5d48-486e-80f5-cde2da3598df", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Day",
                keyColumn: "Date",
                keyValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "d81d414e-5268-40df-9bc6-527570bbc435");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "fcbdd6e6-5d48-486e-80f5-cde2da3598df");

            migrationBuilder.DropColumn(
                name: "StoreSelect",
                table: "Day");

            migrationBuilder.AddColumn<string>(
                name: "Store",
                table: "Day",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Day",
                columns: new[] { "Date", "DailyScheduleList", "RequiredEmployees", "Store" },
                values: new object[] { new DateTime(2020, 4, 12, 17, 6, 35, 166, DateTimeKind.Local).AddTicks(6922), "", null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "a6bc572c-d2ed-4402-a1c5-9ee6bbb91c10", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "d97ea811-e404-4081-8a56-afa0aaf0a4ee", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }
    }
}
