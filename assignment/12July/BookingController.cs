
using _12_Aug_Assign.Repository;
using Microsoft.AspNetCore.Mvc;


namespace _12_Aug.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService service;

        public BookingController(IBookingService service)
        {
            this.service = service;
        }


        // Get all bookings
        [HttpGet]
        public IActionResult GetBookings()
        {
            var bookings = service.GetBookings();

            return Ok(bookings);
        }


        // Get booking by ID
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var booking = service.GetBookingById(id);

            if (booking == null)
            {
                return NotFound("Booking not found");
            }

            return Ok(booking);
        }


        // Create booking
        [HttpPost]
        public IActionResult CreateBooking(
            int customerId,
            DateTime checkin,
            DateTime checkout,
            List<int> roomIds)
        {
            try
            {
                var booking = service.CreateBooking(
                    customerId,
                    checkin,
                    checkout,
                    roomIds);

                return Ok(booking);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // Get rooms
        [HttpGet("rooms")]
        public IActionResult GetRooms()
        {
            var rooms = service.GetRooms();

            return Ok(rooms);
        }
    }
}
