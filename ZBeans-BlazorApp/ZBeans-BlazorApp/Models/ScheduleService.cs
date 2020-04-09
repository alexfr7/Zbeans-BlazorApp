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

            
            Week.Add( scheduleContext.Monday.Find(dayTracker));
            Week.Add(scheduleContext.Tuesday.Find(dayTracker.AddDays(1)));
            Week.Add(scheduleContext.Wednesday.Find(dayTracker.AddDays(2)));
            Week.Add(scheduleContext.Thursday.Find(dayTracker.AddDays(3)));
            Week.Add(scheduleContext.Friday.Find(dayTracker.AddDays(4)));
            Week.Add(scheduleContext.Saturday.Find(dayTracker.AddDays(5)));
            Week.Add(scheduleContext.Sunday.Find(dayTracker.AddDays(6)));

            return Week;

        }

       
    }
}
