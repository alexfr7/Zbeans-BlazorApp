using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZBeans_BlazorApp.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "0e721673-7a49-4d77-b744-49fd11858d83");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "b55a1161-9b44-4df1-835f-6344c04b5ffd");

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Date = table.Column<DateTime>(nullable: false),
                    DailyScheduleList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Date);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "d48cfe37-05b3-44f3-92f5-a7691a38c5f7", "Alex", "Frink", "Experienced" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "5f4a50a2-2ffe-4ab1-8267-3da3e44a4a36", "Nick", "Rogie", "Entry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Day");

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
                values: new object[] { "0e721673-7a49-4d77-b744-49fd11858d83", "Alex", "Frink", "Experienced" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Level" },
                values: new object[] { "b55a1161-9b44-4df1-835f-6344c04b5ffd", "Nick", "Rogie", "Entry" });
        }
    }
}
