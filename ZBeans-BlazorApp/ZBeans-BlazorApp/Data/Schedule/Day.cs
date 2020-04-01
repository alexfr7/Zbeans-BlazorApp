using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ZBeans_BlazorApp.Models;

namespace ZBeans_BlazorApp.Data.Schedule
{
    public class Day
    {

        public List<List<Employee>> TimeSlots = new List<List<Employee>>(48);

        public Day()
        {
            for(int i = 0; i < TimeSlots.Capacity; i++)
            {
                TimeSlots[i] = new List<Employee>();
            }
        }


        public void AddEmployee(int i, Employee employee)
        {
            TimeSlots[i].Add(employee);
        }

        public void RemoveEmployee(int i, Employee employee)
        {
            TimeSlots[i].Remove(employee);
        }

        public List<Employee> SuggestedEmployees(int dayOfWeek, int indexOfSlot, List<Employee> employees)
        {
            // Here goes the suggestion Algorithm

            // Prioritized List of Possible Choices
            List<Employee> PossibleChoices = new List<Employee>();

            for(int i = 0; i < employees.Count; i++)
            {
                if(employees[i].IsAvailable(dayOfWeek, indexOfSlot))
                {
                    PossibleChoices.Add(employees[i]);
                }
            }

            return PossibleChoices;
        }





    }
}
