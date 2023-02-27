using Microsoft.EntityFrameworkCore;

namespace SportStoreNetCore.Models.DAL
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> opts) : base(opts)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
