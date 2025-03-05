using EF_CF_MultiTables_Demo.Models;

namespace EF_CF_MultiTables_Demo.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> SearchProducts(string keyword);
    }
}
