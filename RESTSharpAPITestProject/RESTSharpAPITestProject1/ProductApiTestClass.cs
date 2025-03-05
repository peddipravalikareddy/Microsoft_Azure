using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAPITestProject1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
    public class ProductApiTestClass
    {
        private RestClient client;
        private const string BaseUrl = "https://localhost:7114/api/Products";
        [SetUp]
        public void Setup()
        {
            client = new RestClient(BaseUrl);
        }
        [Test]
        public async Task TestAddProduct()
        {
            var request = new RestRequest("/", Method.Post);
            request.AddJsonBody(new
                Product
            { Id = 5, Name = "Product5", Description = "Description5", Category = "Category5", Price = 500 });
            var response = await client.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Does.Contain("Product 5"));
        }
        [Test]
        public async Task TestGetAllProducts()
        {
            var request = new RestRequest("/", Method.Get);
            var response = await client.ExecuteAsync<List<Product>>(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.IsNotNull(response.Data);
            Assert.That(response.Data.Count, Is.GreaterThan(0));
        }
        [Test]
        public async Task TestUpdateProduct()
        {
            var request = new RestRequest("/", Method.Put);
            request.AddJsonBody(new
                Product
            { Id = 1, Name = "Updated Product 1", Description = "Updated Description 1", Category = "Category5", Price = 500 });
            var response = await client.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Does.Contain("Updated"));
        }
        [Test]
        public async Task TestDeleteProduct()
        {
            var request = new RestRequest("/", Method.Delete);
            request.AddJsonBody(new Product
            {
                Id = 2,
                Name = "Product 2",
                Description = "Description 2",
                Category = "Category 2",
                Price = 200
            });
            var response = await client.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Content, Does.Contain("Product Removed"));
        }
        [TearDown]
        public void TearDown()
        {
            client.Dispose();
        }
    }
}