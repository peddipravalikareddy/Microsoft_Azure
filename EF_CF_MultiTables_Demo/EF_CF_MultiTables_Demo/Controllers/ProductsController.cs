using EF_CF_MuliTables_demo.Models;
using EF_CF_MuliTables_demo.Services;

using EF_CF_MultiTables_Demo.Services;

using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace EF_CF_MultiTables_Demo.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class ProductsController : ControllerBase

    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)

        {

            _productService = productService;

        }

        [HttpGet]

        public async Task<IActionResult> GetAll()

        {

            var products = await _productService.GetAllProducts();

            return Ok(products);

        }


        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)

        {

            var product = await _productService.GetProductById(id);

            if (product == null)

                return NotFound();

            return Ok(product);

        }


        [HttpPost]

        public async Task<IActionResult> Add(Product product)

        {

            await _productService.AddProduct(product);

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);

        }


        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, Product product)

        {

            if (id != product.Id)

                return BadRequest();

            await _productService.UpdateProduct(product);

            return NoContent();

        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)

        {

            await _productService.DeleteProduct(id);

            return NoContent();

        }


        [HttpGet("search/{keyword}")]

        public async Task<IActionResult> Search(string keyword)

        {

            var products = await _productService.SearchProducts(keyword);

            return Ok(products);

        }


    }

}