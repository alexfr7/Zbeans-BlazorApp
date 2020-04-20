using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZBeans_BlazorApp.Data.Schedule;

namespace ZBeans_BlazorApp.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Day> Day { get; set; }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Employee>().HasData(
               new
               {
                   EmployeeId = Guid.NewGuid().ToString(),
                   FirstName = "Alex",
                   LastName = "Frink",
                   Level = "Experienced",
                   PreferredDays = "",
                   Location = "Mercer Village"
               },

               new
               {
                   EmployeeId = Guid.NewGuid().ToString(),
                   FirstName = "Nick",
                   LastName = "Rogie",
                   Level = "Entry",
                   PreferredDays = "",
                   Location = "Mercer Village"

               }
                );

            builder.Entity<Day>().HasData(
                new
                {
                    Date = DateTime.MinValue,
                    DailyScheduleList = "",
                    RequiredEmployees = "",
                    StoreSelect = "test",
                });
        }
    }
}
