using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class MergeMig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "d81d414e-5268-40df-9bc6-527570bbc435");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "fcbdd6e6-5d48-486e-80f5-cde2da3598df");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "2f7ea68a-f848-49df-9835-b9101b056fa8", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "37e13a3a-3d33-487d-8136-953ffd920c3e", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "2f7ea68a-f848-49df-9835-b9101b056fa8");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "37e13a3a-3d33-487d-8136-953ffd920c3e");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "d81d414e-5268-40df-9bc6-527570bbc435", "Alex", null, "Frink", "Experienced", "10:00", "M", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "FridayAvailability", "LastName", "Level", "MondayAvailability", "PreferredDays", "SaturdayAvailability", "SundayAvailability", "ThursdayAvailability", "TuesdayAvailability", "WednesdayAvailability" },
                values: new object[] { "fcbdd6e6-5d48-486e-80f5-cde2da3598df", "Nick", null, "Rogie", "Entry", "9:00", "T", null, null, null, null, null });
        }
    }
}
