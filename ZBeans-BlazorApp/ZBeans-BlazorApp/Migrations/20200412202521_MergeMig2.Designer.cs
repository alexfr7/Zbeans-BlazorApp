﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZBeans_BlazorApp.Models;

namespace ZBeans_BlazorApp.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20200412202521_MergeMig2")]
    partial class MergeMig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZBeans_BlazorApp.Data.Schedule.Day", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DailyScheduleList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequiredEmployees")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Date");

                    b.ToTable("Day");

                    b.HasData(
                        new
                        {
                            Date = new DateTime(2020, 4, 12, 16, 25, 21, 202, DateTimeKind.Local).AddTicks(1148),
                            DailyScheduleList = ""
                        });
                });

            modelBuilder.Entity("ZBeans_BlazorApp.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FridayAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MondayAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaturdayAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SundayAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThursdayAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TuesdayAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WednesdayAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = "cecde089-b4c7-4702-bc98-4a5752dc3191",
                            FirstName = "Alex",
                            LastName = "Frink",
                            Level = "Experienced",
                            MondayAvailability = "10:00",
                            PreferredDays = "M"
                        },
                        new
                        {
                            EmployeeId = "37635b38-613d-4ed0-b2fa-315dcef3da63",
                            FirstName = "Nick",
                            LastName = "Rogie",
                            Level = "Entry",
                            MondayAvailability = "9:00",
                            PreferredDays = "T"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
