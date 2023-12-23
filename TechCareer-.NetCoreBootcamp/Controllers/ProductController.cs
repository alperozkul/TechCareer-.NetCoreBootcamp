using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareer_.NetCoreBootcamp.Models;
using TechCareer_.NetCoreBootcamp.Services;

namespace TechCareer_.NetCoreBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> products;

        public ProductController()
        {
            if (products == null) products = ProductService.GetAllProduct();
        }

        [HttpGet]
        public IActionResult getAll()
        {
            return Ok(products);
        }


        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            else return Ok(product);

        }


        [HttpPost]
        public IActionResult create(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return StatusCode(StatusCodes.Status201Created, product);
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            else
            {
                products.Remove(product);
                return Ok(product);
            }
        }
    }
}
