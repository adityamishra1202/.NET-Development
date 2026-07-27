using _27_July_Assign.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _27_July_Assign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>() { 
        
        new Product{Id=101,Product_Name="Biscuit",price=50,Category="Grocery",Stock=50},
        new Product{Id=102,Product_Name="Pen",price=50,Category="Stationary",Stock=500},
        new Product{Id=116,Product_Name="Detergent",price=300,Category="Cleaning agents",Stock=90},
         new Product{Id=111,Product_Name="Namkeen",price=350,Category="Grocery",Stock=200},
                  new Product{Id=109,Product_Name="Notebook",price=1150,Category="Stationary",Stock=30},

 };


        [HttpGet]
        public ActionResult getProduct()
        {
            return Ok(products);
        }
        [HttpGet("{Id}")]
        public ActionResult getProductById(int id)
        {
            var product=products.FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                return BadRequest();
            }
           
            return Ok(product);         

        }
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id,Product pro)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return BadRequest();
            }
            product.price = pro.price;
            

            return Ok(product);

        }
        [HttpPost]
        public ActionResult AddProduct( Product pro)
        {
            products.Add(pro);
            return CreatedAtAction(nameof(getProduct), new { Id = pro.Id },pro);

        }


        [HttpDelete("{id}")]
        
        public ActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return BadRequest();
            }

            products.Remove(product);
            return NoContent();

            }



        [HttpGet("Category/{category}")]
        public ActionResult getProductByCategory(string category)
        {
            var result = products.Where(s => s.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!result.Any()) { return NotFound("Not employee found under this dept"); }
            return Ok(result);

        }
























    }
}
