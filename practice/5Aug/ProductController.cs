using _5_July.Models;

using _5_July.Repository;
using _5_July.Services;
using Microsoft.AspNetCore.Mvc;

namespace _5_July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       
       
     
            private readonly IProductService service;

            public ProductController(IProductService service)
            {
                this.service = service;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                return Ok(service.GetAll());
            }

            [HttpGet("{id}")]
            public IActionResult GetProduct(int id)
            {
                var product = service.GetProduct(id);

                if (product == null)
                    return NotFound("Product is not available");

                return Ok(product);
            }

            [HttpPost]
            public IActionResult AddP(Product product)
            {
                service.AddProduct(product);
                return Ok(product);
            }

            [HttpPut]
            public IActionResult UpdateP(Product product)
            {
                service.UpdateProduct(product);
                return Ok("Product Updated Successfully");
            }
        [HttpDelete]
        public IActionResult DeleteP(int id)
        {
            service.DeleteProduct(id);
            return Ok("Product deleted successfully");
        }
    }
    }

