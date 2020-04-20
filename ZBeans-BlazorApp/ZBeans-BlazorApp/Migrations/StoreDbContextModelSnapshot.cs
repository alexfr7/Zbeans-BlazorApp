﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZBeans_BlazorApp.Models;

namespace ZBeans_BlazorApp.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("StoreSelect")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Date");

                    b.ToTable("Day");

                    b.HasData(
                        new
                        {
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DailyScheduleList = "",
                            RequiredEmployees = "",
                            StoreSelect = "test"
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

                    b.Property<string>("Location")
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
                            EmployeeId = "6361beb8-ea2a-4c34-96fb-d279f0b48daf",
                            FirstName = "Alex",
                            LastName = "Frink",
                            Level = "Experienced",
                            Location = "Mercer Village",
                            MondayAvailability = "10:00",
                            PreferredDays = "M"
                        },
                        new
                        {
                            EmployeeId = "797449c5-1a4e-44e8-b058-198efc80dae3",
                            FirstName = "Nick",
                            LastName = "Rogie",
                            Level = "Entry",
                            Location = "Mercer Village",
                            MondayAvailability = "9:00",
                            PreferredDays = "T"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
