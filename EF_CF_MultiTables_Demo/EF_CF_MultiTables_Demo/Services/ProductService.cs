using EF_CF_MuliTables_demo.Models;
using EF_CF_MuliTables_demo.Repositories;
using EF_CF_MuliTables_demo.Services;
using EF_CF_MultiTables_Demo.Models;
using EF_CF_MultiTables_Demo.Repository;


namespace EF_CF_MultiTables_Demo.Services

{

    public class ProductService : IProductService

    {

        private readonly IProductRepository _productRepository;


        public ProductService(IProductRepository productRepository)

        {

            _productRepository = productRepository;

        }


        public async Task<IEnumerable<Product>> GetAllProducts()

        {

            return await _productRepository.GetAll();

        }


        public async Task<Product> GetProductById(int id)

        {

            var product = await _productRepository.GetById(id);

            if (product == null)

            {

                throw new Exception("Product not found.");

            }

            return product;

        }


        public async Task AddProduct(Product product)

        {

            if (string.IsNullOrEmpty(product.Name) || product.Price <= 0)

            {

                throw new Exception("Invalid product details.");

            }

            await _productRepository.Add(product);

        }


        public async Task UpdateProduct(Product product)

        {

            var existingProduct = await _productRepository.GetById(product.Id);

            if (existingProduct == null)

            {

                throw new Exception("Product not found.");

            }

            existingProduct.Name = product.Name;

            existingProduct.Price = product.Price;

            existingProduct.CategoryId = product.CategoryId;

            await _productRepository.Update(existingProduct);

        }


        public async Task DeleteProduct(int id)

        {

            var product = await _productRepository.GetById(id);

            if (product == null)

            {

                throw new Exception("Product not found.");

            }

            await _productRepository.Delete(id);

        }


        public async Task<IEnumerable<Product>> SearchProducts(string keyword)

        {

            return await _productRepository.SearchProducts(keyword);

        }


    }

}