using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZBeans_BlazorApp.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Level { get; set; }
        [Required]
        public string Location { get; set; }
        public string PreferredDays { get; set; }

        public string MondayAvailability { get; set; }
        public string TuesdayAvailability { get; set; }
        public string WednesdayAvailability { get; set; }
        public string ThursdayAvailability { get; set; }
        public string FridayAvailability { get; set; }
        public string SaturdayAvailability { get; set; }
        public string SundayAvailability { get; set; }

    }
}
