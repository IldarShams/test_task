using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace App
{
    public class PostgreSQLContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<Subdivision_employees> Subdivision_employees { get; set; }
        public PostgreSQLContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test_task;Username=postgres;Password=admin");
        }
    }
}