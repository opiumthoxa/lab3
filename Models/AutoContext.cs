using Microsoft.EntityFrameworkCore;

namespace SalonAutosport.Models
{
    public class AutosportContext : DbContext
    {
        public DbSet<Auto> Auto { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AutosportContext(DbContextOptions<AutosportContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
