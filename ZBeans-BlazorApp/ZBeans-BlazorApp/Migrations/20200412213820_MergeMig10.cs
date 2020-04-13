using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class MergeMig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "cba0b296-6d08-4790-9ba7-e606d8aea4ef");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "f307bbc7-6a1d-459c-b3f2-e7545b4ecfa0");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "3d55abc4-0787-4aa9-b551-4d61498ec9d6", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "78c8efec-eed5-4f9b-9e99-e9e74fc7607f", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "3d55abc4-0787-4aa9-b551-4d61498ec9d6");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "78c8efec-eed5-4f9b-9e99-e9e74fc7607f");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "cba0b296-6d08-4790-9ba7-e606d8aea4ef", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "f307bbc7-6a1d-459c-b3f2-e7545b4ecfa0", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }
    }
}
