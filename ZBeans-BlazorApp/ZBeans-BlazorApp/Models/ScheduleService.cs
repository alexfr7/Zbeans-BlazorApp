using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZBeans_BlazorApp.Data.Schedule;

namespace ZBeans_BlazorApp.Models
{
    public class ScheduleService
    {

        StoreDbContext scheduleContext ;
        const string DefaultDaySlots = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";
        

        public ScheduleService(StoreDbContext _context)
        {
            scheduleContext = _context;
            
        }

        public async Task<List<Day>> GetScheduleAsync(DateTime WeekOfYear)
        {
            // List of 7 days to return
            List<Day> Week = new List<Day>(7);
            
            // Get the first day of the requested week, at Monday.
            DateTime dayTracker = WeekOfYear.StartOfWeek(DayOfWeek.Monday);

            for(int i = 0; i < 7; i++)
            {
                if(scheduleContext.Day.Find(dayTracker.AddDays(i)) == null)
                {
                    await InsertDayAsync(new Day { Date = dayTracker.AddDays(i), DailyScheduleList = DefaultDaySlots });
                }
                Week.Add(scheduleContext.Day.Find(dayTracker.AddDays(i)));
            }
            return Week;

        }

        public async Task InsertDayAsync(Day day)
        {
            //Correct for starting the week on Monday
            scheduleContext.Day.Add(day);

            await scheduleContext.SaveChangesAsync();
            
        }

        // Replaces the previous entry at a certain day with a new one.
        public async Task ReplaceDayAsync(DateTime date, Day day)
        {

            Day tempday = scheduleContext.Day.Find(date);
            tempday.DailyScheduleList = day.DailyScheduleList;
            scheduleContext.Day.Update(tempday);
            await scheduleContext.SaveChangesAsync();

        }

        public async Task<Day> GetDayAsync(Day day)
        {
            return await scheduleContext.Day.FindAsync(day.Date);
        }


        public async Task AddEmployeeAsync(Employee employee, Day day, int timeSlot)
        {
            day.AddEmployee(timeSlot, employee);
            await ReplaceDayAsync(day.Date, day);
        }



       
    }
}
