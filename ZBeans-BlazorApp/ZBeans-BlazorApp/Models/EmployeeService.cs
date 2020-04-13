using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ZBeans_BlazorApp.Models
{
    public class EmployeeService
    {
        StoreDbContext _context;
        public EmployeeService(StoreDbContext context)
        {
            _context = context;
        }


        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToLis();
        }

        public async Task<Employee> GetEmployeeByIdAsync(string id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<Employee> InsertEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateEmployeeAsync(string id, Employee e)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return null;

            employee.FirstName = e.FirstName;
            employee.LastName = e.LastName;
            employee.Level = e.Level;
            employee.MondayAvailability = e.MondayAvailability;
            employee.PreferredDays = e.PreferredDays;
            employee.TuesdayAvailability = e.TuesdayAvailability;
            employee.WednesdayAvailability = e.WednesdayAvailability;
            employee.ThursdayAvailability = e.ThursdayAvailability;
            employee.FridayAvailability = e.FridayAvailability;
            employee.SaturdayAvailability = e.SaturdayAvailability;
            employee.SundayAvailability = e.SundayAvailability;


            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> DeleteEmployeeAsync(string id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
                return null;

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        private bool EmployeeExists(string id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }


    }
}
