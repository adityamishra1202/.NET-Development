using _10_Aug_Assign.Models;
using _10_Aug_Assign.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _10_Aug_Assign.Controllers
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

        [HttpPut("{id}")]
        public ActionResult Update(int id,Booking book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }
            var existing = service.GetBookingById(id);

            if (existing == null)
            {
                return NotFound();
            }
            service.UpdateBooking(book);
            return Ok(book);
        }
    }
}

