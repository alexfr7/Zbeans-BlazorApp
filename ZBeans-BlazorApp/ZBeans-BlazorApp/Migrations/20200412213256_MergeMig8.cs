using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class MergeMig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "2f7ea68a-f848-49df-9835-b9101b056fa8");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "37e13a3a-3d33-487d-8136-953ffd920c3e");

            migrationBuilder.AlterColumn<string>(
                name: "StoreSelect",
                table: "Day",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "Date",
                keyValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                column: "StoreSelect",
                value: "test");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "a4241e90-0f46-4099-aacd-103363122c93", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "84a832e0-f2f2-4286-ab92-e46c1e112b47", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "84a832e0-f2f2-4286-ab92-e46c1e112b47");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "a4241e90-0f46-4099-aacd-103363122c93");

            migrationBuilder.AlterColumn<string>(
                name: "StoreSelect",
                table: "Day",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "Date",
                keyValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                column: "StoreSelect",
                value: "");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "37e13a3a-3d33-487d-8136-953ffd920c3e", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "2f7ea68a-f848-49df-9835-b9101b056fa8", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });
        }
    }
}
