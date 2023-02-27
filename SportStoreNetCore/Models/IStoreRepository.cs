using System.Linq;

namespace SportStoreNetCore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
