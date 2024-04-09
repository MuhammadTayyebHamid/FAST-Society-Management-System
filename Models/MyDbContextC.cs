using Microsoft.EntityFrameworkCore;

namespace SE_Project.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Society> Societies { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Tasks> Tasks { get; set; } // Add DbSet for Tasks

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}
