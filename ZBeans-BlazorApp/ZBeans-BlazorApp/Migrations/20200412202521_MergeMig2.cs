using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class MergeMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RequiredEmployees",
                table: "Day",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Day",
                columns: new[] { "Date", "DailyScheduleList", "RequiredEmployees" },
                values: new object[] { new DateTime(2020, 4, 12, 16, 25, 21, 202, DateTimeKind.Local).AddTicks(1148), "", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "cecde089-b4c7-4702-bc98-4a5752dc3191", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "37635b38-613d-4ed0-b2fa-315dcef3da63", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Day",
                keyColumn: "Date",
                keyValue: new DateTime(2020, 4, 12, 16, 25, 21, 202, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "37635b38-613d-4ed0-b2fa-315dcef3da63");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "cecde089-b4c7-4702-bc98-4a5752dc3191");

            migrationBuilder.DropColumn(
                name: "RequiredEmployees",
                table: "Day");

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
    }
}
