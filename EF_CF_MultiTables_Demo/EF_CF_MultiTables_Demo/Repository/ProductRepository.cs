using EF_CF_MultiTables_Demo.Data;
using EF_CF_MultiTables_Demo.Models;
using EF_CF_MultiTables_Demo.Repository;
using Microsoft.EntityFrameworkCore;


namespace EF_CF_MultiTables_Demo.Repositories

{

    public class ProductRepository : IProductRepository

    {

        private readonly MyContext _context;


        public ProductRepository(MyContext context)

        {

            _context = context;

        }


        public async Task<Product> Add(Product product)

        {

            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return product;

        }


        public async Task<string> Delete(int id)

        {

            var product = _context.Products.Find(id);

            if (product != null)

            {

                _context.Products.Remove(product);

                _context.SaveChanges();

                return "Product Removed";


            }

            else

                return "Product not available";

        }


        public async Task<IEnumerable<Product>> GetAll()

        {

            return await _context.Products.ToListAsync();

        }


        public async Task<Product> GetById(int id)

        {

            return await _context.Products.FindAsync(id);

        }


        public async Task<IEnumerable<Product>> SearchProducts(string keyword)

        {

            return await _context.Products

            .Where(p => p.Name.Contains(keyword))

            .ToListAsync();

        }


        public async Task<Product> Update(Product product)

        {

            var updateProduct = await _context.Products.FindAsync(product.Id);

            if (updateProduct == null)

            {

                return null; // Return null if product not found

            }


            updateProduct.Name = product.Name;

            updateProduct.Price = product.Price;


            await _context.SaveChangesAsync();

            return updateProduct; // Return updated product

        }

    }

}