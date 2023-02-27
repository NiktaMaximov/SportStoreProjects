using SportStoreNetCore.Models.DAL;
using System.Linq;

namespace SportStoreNetCore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        public StoreDBContext dbContext;
        public EFStoreRepository(StoreDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<Product> Products => dbContext.Products;
    }
}
