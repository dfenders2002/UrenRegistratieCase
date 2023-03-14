using Microsoft.EntityFrameworkCore;
using UrenRegistratieAPI.Models;

namespace UrenRegistratieAPI.data
{
    public class UrenRegistratieDbContext:DbContext
    {
        public UrenRegistratieDbContext(DbContextOptions<UrenRegistratieDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
