using EF_CF_MuliTables_demo.Models;
using EF_CF_MultiTables_Demo.Models;

namespace EF_CF_MuliTables_demo.Services
{
    public interface IProductService

    {

        Task<IEnumerable<Product>> GetAllProducts();

        Task<Product> GetProductById(int id);

        Task AddProduct(Product product);

        Task UpdateProduct(Product product);

        Task DeleteProduct(int id);

        Task<IEnumerable<Product>> SearchProducts(string keyword);


    }
}