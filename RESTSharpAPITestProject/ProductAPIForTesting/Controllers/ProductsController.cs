using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPIForTesting.Model;
using System.Security.Cryptography.X509Certificates;

namespace ProductAPIForTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> products = new List<Product>();
        public ProductsController()
        {
            if (products.Count == 0)
            {
                products.Add(new Product { Id = 1, Name = "Product1", Description = "Description1", Category = "Category1", Price = 100 });
                products.Add(new Product { Id = 2, Name = "Product2", Description = "Description2", Category = "Category2", Price = 200 });
                products.Add(new Product { Id = 3, Name = "Product3", Description = "Description3", Category = "Category3", Price = 300 });
                products.Add(new Product { Id = 4, Name = "Product4", Description = "Description4", Category = "Category4", Price = 400 });
            }
        }
        [HttpGet]
        public List<Product> Get()
        {
            return products;
        }
        [HttpPost]
        public string AddNewProducts(Product product)
        {
            products.Add(product);
            return "Product 5";
        }
        [HttpPut]
        public string UpdateProduct(Product product)
        {
            Product productToUpdate = products.First(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Description = product.Description;
                productToUpdate.Category = product.Category;
                productToUpdate.Price = product.Price;
                return "Updated";
            }
            else
            {
                return "Product not found";
            }
        }
        [HttpDelete]
        public string DeleteProduct(Product product)
        {
            Product productToDelete = products.Find(p => p.Id == product.Id);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
                return "Product Removed";
            }
            else
            {
                return "Product not found";
            }
        }
    }
}