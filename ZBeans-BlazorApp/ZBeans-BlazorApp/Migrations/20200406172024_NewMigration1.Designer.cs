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
    [Migration("20200406172024_NewMigration1")]
    partial class NewMigration1
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

                    b.HasKey("Date");

                    b.ToTable("Day");
                });

            modelBuilder.Entity("ZBeans_BlazorApp.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = "3f303ad2-8013-4835-af28-484507ebd23f",
                            FirstName = "Alex",
                            LastName = "Frink",
                            Level = "Experienced"
                        },
                        new
                        {
                            EmployeeId = "d2e84526-a739-4c71-9d02-0e07120ee7b8",
                            FirstName = "Nick",
                            LastName = "Rogie",
                            Level = "Entry"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
