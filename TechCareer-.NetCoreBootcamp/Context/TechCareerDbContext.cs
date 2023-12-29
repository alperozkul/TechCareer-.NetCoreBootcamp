using Microsoft.EntityFrameworkCore;
using TechCareer_.NetCoreBootcamp.Models.ORM;

namespace TechCareer_.NetCoreBootcamp.Context
{
    public class TechCareerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TechCareerDb;Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }
    }
}
