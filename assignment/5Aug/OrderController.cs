using _5_July.Models;
using _5_July.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5_July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService service;
        public OrderController(IOrderService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var c = service.GetOrders();
            return Ok(c);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var c = service.GetOrder(id);
            return Ok(c);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Order o)
        {
            if (id != o.OrderId)
            {
                return BadRequest();
            }

            var existing = service.GetOrder(id);

            if (existing == null)
            {
                return NotFound();
            }

            service.UpdateOrder(o);

            return Ok(o);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var o = service.GetOrder(id);

            if (o == null)
            {
                return NotFound();
            }

            service.DeleteOrder(id);

            return Ok("Order Deleted Successfully");

        }
    }
}
