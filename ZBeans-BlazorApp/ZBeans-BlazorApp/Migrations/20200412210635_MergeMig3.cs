using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class MergeMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Store",
                table: "Day",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Store",
                table: "Day");

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
    }
}
