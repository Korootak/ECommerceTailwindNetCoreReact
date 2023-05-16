using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ECommerceAPI.Models;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // This is just for example, you would want to get your products from a database
        private static readonly List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Description = "This is product 1", Price = 9.99m, ImageUrl = "https://example.com/product1.jpg" },
            new Product { Id = 2, Name = "Product 2", Description = "This is product 2", Price = 19.99m, ImageUrl = "https://example.com/product2.jpg" },
            // Add more products here
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return products;
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
    }
}
