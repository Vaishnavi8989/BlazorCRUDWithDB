using BlazorCRUDWithDB.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorCRUDWithDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
