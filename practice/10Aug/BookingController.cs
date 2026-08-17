using _10_Aug.Models;
using _10_Aug.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Buffers.Text;

namespace _10_Aug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        
            private readonly IBookingService service;

            public BookingController(IBookingService service)
            {
                this.service = service;
            }

            [HttpPost]
            public IActionResult CreateBooking(Booking booking)
            {
                try
                {
                    var result = service.CreateBooking(booking);
                    return Ok(result);
                }
                catch (ArgumentException ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpGet]
            public IActionResult GetBookings()
            {
                return Ok(service.GetBookings());
            }

            [HttpGet("{id}")]
            public IActionResult GetBookingById(int id)
            {
                var booking = service.GetBookingById(id);

                if (booking == null)
                    return NotFound("Booking not found");

                return Ok(booking);
            }
        }
}
