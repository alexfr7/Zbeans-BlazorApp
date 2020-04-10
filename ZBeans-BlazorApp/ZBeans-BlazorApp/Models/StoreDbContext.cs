using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZBeans_BlazorApp.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

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
                   PreferredDays = "M",
                   MondayAvailability = "10:00"
               },

               new
               {
                   EmployeeId = Guid.NewGuid().ToString(),
                   FirstName = "Nick",
                   LastName = "Rogie",
                   Level = "Entry",
                   PreferredDays = "T",
                   MondayAvailability = "9:00"

               }
                );
        }
    }
}
