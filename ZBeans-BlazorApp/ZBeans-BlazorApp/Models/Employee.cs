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

        public bool isAvailable(int _dayIndex, int _timeIndex)
        {
            string[] availabilities = { MondayAvailability, TuesdayAvailability, WednesdayAvailability, ThursdayAvailability, FridayAvailability, SaturdayAvailability, SundayAvailability };

            if (availabilities[_dayIndex].Length > 0)
            {
                List<int> timesAvailible = getAvailabilities(availabilities[_dayIndex]);

                // -9 because of a discrepancy between the way Employee availability is stored and the index of the time period out of 48.
                // For instance, 8:00 AM is stored as 7(3:30 AM) when it should be stored as 16(8:00 AM)
                // This is just a quick fix, and should be later changed.
                return timesAvailible.Contains(_timeIndex-9);
            }
            else return false;
        }

        private List<int> getAvailabilities(string DayString)
        {
            string[] availabilities = DayString.Split(',');

            List<int> availInts = new List<int>();
            
            foreach(string s in availabilities)
            {

                availInts.Add(Convert.ToInt32(s));
            }

            return availInts;
        }
    }
}
