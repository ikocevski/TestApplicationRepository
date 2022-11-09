using Microsoft.EntityFrameworkCore;
using TestAppWeb.Models;

namespace TestAppWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }

        public DbSet<Hierarchy> Hierarchies { get; set; } 
        public DbSet<ProgressBar> ProgressBars { get; set; }   
    }
}
