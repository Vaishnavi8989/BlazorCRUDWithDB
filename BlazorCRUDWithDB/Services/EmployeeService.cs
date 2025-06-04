using BlazorCRUDWithDB.Data;
using BlazorCRUDWithDB.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUDWithDB.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllAsync() => await _context.Employees.ToListAsync();

        public async Task<Employee> GetByIdAsync(int id) => await _context.Employees.FindAsync(id);

        public async Task AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> EmployeeExistsAsync(string name)
        {
            return await _context.Employees.AnyAsync(e => e.Name == name);
        }
        //public async Task<bool> EmployeeEmailExistsAsync(string email)
        //{
        //    return await _context.Employees.AnyAsync(e => e.Email == email);
        //}
        public void SomeMethod()
        {
            Console.WriteLine("Hello");  // ← missing closing parenthesis and semicolon
}

    }
}
