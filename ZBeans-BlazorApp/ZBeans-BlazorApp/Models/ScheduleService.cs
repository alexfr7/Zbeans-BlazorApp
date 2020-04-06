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
        Schedule daySchedule = new Schedule();
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
            




            
            //daySchedule.WeekSchedule[(int)dayTracker.DayOfWeek].TimeSlots = 
        }
    }
}
