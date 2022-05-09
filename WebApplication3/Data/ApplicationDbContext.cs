using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Youtube> Youtube { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
