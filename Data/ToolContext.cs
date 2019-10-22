using Microsoft.EntityFrameworkCore;
using StudentEmployeeManagementApp.Models;

namespace SmukToolsApp.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Shift> Shifts { get; set; }
        public DbSet<StudentEmployeeManagementApp.Models.EmployeeRole> EmployeeRoles { get; set; }

        public DbSet<StudentEmployeeManagementApp.Models.Employee> Employees { get; set; }
        public DbSet<EmployeeShiftManagement.Models.ShiftApplications> ShiftApplications { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }


        
    }
}
