using Angular5Identity.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace Angular5Identity.Server.Helpers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users {get; set;}
    }
}