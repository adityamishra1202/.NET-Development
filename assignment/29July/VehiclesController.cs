using _29_July.Models;
using _29_July.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _29_July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehiclesController(IVehicleService service)
        {
            _service = service;
        }

        // Get all vehicles
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetVehicles());
        }

        // Add a new vehicle
        [HttpPost]
        public IActionResult Post(Vehicle vehicle)
        {
            var result = _service.AddVehicle(vehicle);
            return Ok(result);
        }

        // Update vehicle by Id
        [HttpPut("{id}")]
        public IActionResult Put(int id, Vehicle vehicle)
        {
            var result = _service.UpdateVehicle(id, vehicle);

            if (result == null)
            {
                return NotFound("Vehicle not found");
            }

            return Ok(result);
        }

        // Get vehicles by number of wheels
        [HttpGet("wheels/{wheels}")]
        public IActionResult GetByWheels(int wheels)
        {
            var result = _service.GetVehicleByWheels(wheels);

            if (result == null || result.Count == 0)
            {
                return NotFound("No vehicles found");
            }

            return Ok(result);
        }

    }
}
