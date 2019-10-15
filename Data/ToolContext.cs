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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shift>().ToTable("Shifts");
        }
        
    }
}
