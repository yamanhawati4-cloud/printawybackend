using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace Printawyapis.Controllers
{
    [ApiController]                    // Marks this class as an API controller
    [Route("api/[controller]")]        // Route will be: /api/users
    public class Products : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = new[]
            {
                new { Id = 1, Price = 350, Name = "Summer T-shirt" , Description = "Customizable Summer T-shirt", Photo = "https://cdn11.bigcommerce.com/s-ycdesmekc9/images/stencil/640w/products/442/9693/5030_BOX_TEE_MUSHROOM_THUMB__02517.1.jpg"},
                new { Id = 2, Price = 500, Name = "Polo T-shirt" , Description = "Customizable Polo T-shirt", Photo = "https://m.media-amazon.com/images/I/51K5IcK9MRL._AC_SX385_.jpg"},
                new { Id = 3, Price = 230, Name = "chemise" , Description = "Customizable chemise", Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8aWRPt3C3shZzZcQ-cuMo7EhTrTZlCGc5lg&s"},
            };
            return Ok(products);          // Returns HTTP 200 with JSON
        }
        
    }

    // Example model
    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}