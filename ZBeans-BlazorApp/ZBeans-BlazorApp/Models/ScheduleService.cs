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

            
            Week.Add(scheduleContext.Day.Find(dayTracker)); //Monday
            Week.Add(scheduleContext.Day.Find(dayTracker.AddDays(1))); //Tuesday
            Week.Add(scheduleContext.Day.Find(dayTracker.AddDays(2))); //Wednesday
            Week.Add(scheduleContext.Day.Find(dayTracker.AddDays(3))); //Thursday
            Week.Add(scheduleContext.Day.Find(dayTracker.AddDays(4))); //Friday
            Week.Add(scheduleContext.Day.Find(dayTracker.AddDays(5)));
            Week.Add(scheduleContext.Day.Find(dayTracker.AddDays(6)));

            return Week;

        }

        public async Task InsertDayAsync(Day day)
        {
            //Correct for starting the week on Monday
            scheduleContext.Day.Add(day);

            await scheduleContext.SaveChangesAsync();
            
        }



       
    }
}
