using Microsoft.EntityFrameworkCore;

namespace SE_Project.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Society> Societies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}