using Microsoft.EntityFrameworkCore;

namespace SE_Project.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Society> Societies { get; set; }

        public MyDbContext(DbContextOptions options) : base(options) {
            
        }

        
    }
}