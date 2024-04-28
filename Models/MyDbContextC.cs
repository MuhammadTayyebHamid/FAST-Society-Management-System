using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace SE_Project.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Society> Societies { get; set; }
        public DbSet<Announcements> announcements { get; set; }
        public DbSet<Events> Events { get; set; }

        public DbSet<Budget> Budget { get; set; }
        public DbSet<Meetings> Meetings { get; set; }
        public DbSet<Members> Members { get; set; }

        public DbSet<Students> Students { get; set; }
        public DbSet<Tasks> Tasks { get; set; } // Add DbSet for Tasks


        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}
