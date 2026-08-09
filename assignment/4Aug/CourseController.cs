using _4_Aug.Models;
using _4_Aug.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4_Aug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CourseController : ControllerBase
    {
        private readonly ICourseService service;

        public CourseController(ICourseService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var c = service.GetCourse(id);

            if (c == null)
            {
                return NotFound("Course not found");
            }

            return Ok(c);
        }

        [HttpPost]
        public IActionResult AddS(Course c)
        {
            service.AddCourse(c);

            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = service.GetCourse(id);

            if (student == null)
            {
                return NotFound();
            }

            service.DeleteCourse(id);

            return Ok("Course Deleted Successfully");
        }
    }
}


