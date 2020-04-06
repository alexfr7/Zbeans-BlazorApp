using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ZBeans_BlazorApp.Data.Schedule;

namespace ZBeans_BlazorApp.Models
{
    public class Schedule
    {
        public List<Day> WeekSchedule = new List<Day>(7);
        
        public Schedule()
        {
            for(int i = 0; i < WeekSchedule.Capacity; i++)
            {
                WeekSchedule.Add(new Day());
            }
        }

    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
