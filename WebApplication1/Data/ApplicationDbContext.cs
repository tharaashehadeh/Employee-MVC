using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext :DbContext
    {     public DbSet<Employee> Employees { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=employee;trusted_connection=true; trustServerCertificate=true");
        }
    }
}
