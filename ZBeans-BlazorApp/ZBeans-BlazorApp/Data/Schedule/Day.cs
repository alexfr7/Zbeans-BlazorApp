using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ZBeans_BlazorApp.Models;

namespace ZBeans_BlazorApp.Data.Schedule
{
    public class Day
    {
        // For storage of each day, we have to get creative
        // Store a delimited string with all of the employee info in it.
        public static string[] Stores = { "Mercer Village", "Downtown", "Coliseum", "N/A"};

        [Key]
        public DateTime Date { get; set; }

        public string DailyScheduleList { get; set; } = "";

        public string RequiredEmployees { get; set; } = "";
        
        public string StoreSelect { get; set; } = "Mercer Village";

        // Data handling will go through here.
        private List<List<Employee>> TimeSlots = new List<List<Employee>>(48);

        public Day()
        {
            for(int i = 0; i < TimeSlots.Capacity; i++)
            {
                TimeSlots.Add(new List<Employee>());
            }
        }

        public List<Employee> GetEmployees(int slot)
        {
            return TimeSlots[slot];
        }
        public void AddEmployee(int i, Employee employee)
        {
            TimeSlots[i].Add(employee);
            ParseToScheduleList();
        }

        public void RemoveEmployee(int i, Employee employee)
        {
            TimeSlots[i].Remove(employee);
            ParseToScheduleList();
        }

        public List<Employee> SuggestedEmployees(int dayOfWeek, int indexOfSlot, List<Employee> employees)
        {
            // Here goes the suggestion Algorithm

            // Prioritized List of Possible Choices
            List<Employee> PossibleChoices = new List<Employee>();

           

            return PossibleChoices;
        }

        public void ParseToScheduleList()
        {
            // Schedule times separated by commas; employee id's separated by semicolons
            string DaySchedule = "";
            for(int i = 0; i < TimeSlots.Capacity; i++)
            {
                for(int j = 0; j < TimeSlots[i].Count; j++)
                {
                    DaySchedule += TimeSlots[i][j].EmployeeId;
                    DaySchedule += ';';
                }

                DaySchedule += ',';
            }
            DailyScheduleList = DaySchedule;
        }

        public void ParseFromScheduleList(List<Employee> employees)
        {
            // This should be called after the string for the day is populated in the database.

            // There will be 48 'slots', delimited by commas.
            int strIndex = 0;
            int endIndex = 0;

            int slotCt = 0;
            List<List<Employee>> TempTimeSlot = new List<List<Employee>>(48);
            for(int i = 0; i < TempTimeSlot.Capacity; i++)
            {
                TempTimeSlot.Add(new List<Employee>());
            }

            while (slotCt < 48)
            {
                // The end of the first slot is the substring from the start of this slot to the comma.
                endIndex = DailyScheduleList.IndexOf(',', strIndex);
                string EmployeesAtTime = DailyScheduleList.Substring(strIndex, endIndex - strIndex);
                // Parse the Employee Id's from the substring

                int empIndexStart = 0;
                int empIndexEnd = 0;

                while(empIndexStart < EmployeesAtTime.Length)
                {
                    empIndexEnd = EmployeesAtTime.IndexOf(';');
                    if(empIndexEnd == -1)
                    {
                        empIndexEnd = 0;
                    }
                    string EmployeeID = EmployeesAtTime.Substring(empIndexStart, empIndexEnd - empIndexStart);

                    //Add the employee id to the time slot list if it matches one we already have.
                    bool matchFlag = false;
                    int sourceIndex = -1;
                    for(int i = 0; i < employees.Count; i ++)
                    {
                        if (employees[i].EmployeeId == EmployeeID)
                        {
                            matchFlag = true;
                            sourceIndex = i;
                        }
                    }
                    if(matchFlag)
                    {
                        TempTimeSlot[slotCt].Add(employees[sourceIndex]);
                    }

                    empIndexStart = empIndexEnd + 1;
                }

                strIndex = endIndex + 1;

                slotCt++;
            }
            TimeSlots = TempTimeSlot;
        }

        public List<int> EmployeeRequirements()
        {
            string[] numList = RequiredEmployees.Split(',');
            List<int> requirements = new List<int>();

            for(int i = 0; i < 48; i++)
            { 
                requirements.Add(Convert.ToInt32(numList[i]));
            }

            return requirements;
        }

    }
}
