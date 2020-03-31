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

        public List<bool[]> Availibility = new List<bool[]>(7);

        public Employee()
        {
            for(int i = 0; i < Availibility.Capacity; i++)
            {
                Availibility.Add(new bool[48]);
                for(int j = 0; j < Availibility[i].Length; j++)
                {
                    Availibility[i][j] = false;
                }
            }
        }

        public bool IsAvailable(int dayOfWeek, int index)
        {
            return (Availibility[dayOfWeek][index]);
        }

    }
}
