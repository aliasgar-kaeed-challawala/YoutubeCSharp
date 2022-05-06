using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication3.Models.Youtube> Youtube { get; set; }

    }
}
