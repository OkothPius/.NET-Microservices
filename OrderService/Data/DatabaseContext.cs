using Microsoft.EntityFrameworkCore;

namespace OrderService.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        public DbSet<Order> Orders { get; set; }
    }
}
