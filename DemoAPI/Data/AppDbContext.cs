using DemoAPI;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gun> Guns { get; set; }
    }
}
