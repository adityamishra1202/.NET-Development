using _3_July.Models;
using _3_July.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;
        public CourseController(ICourseService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetCourse()
        {
            var course = _service.GetCourse();
            return Ok(course);

        }
        [HttpPut("{id}")]
        public ActionResult UpdateCourse(int id, Course course)
        {
            var result = _service.UpdateCourse(id, course);
            if (result == null)
            {
                return BadRequest("No such batch exists");
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBatch(int id)
        {
            bool t = _service.DeleteCourse(id);
            if (t)
            {
                return Ok("Found and delted");
            }
            return BadRequest("Not found");
        }
        [HttpGet("Duration/{duration}")]
        public ActionResult GetCourse(int duration)
        {
            var result=_service.GetCourseWithDuration(duration);
            if (!result.Any()) { return NotFound("Not employee found under this dept"); }
            return Ok(result);
        }
        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            var result= _service.AddCourse(course); 
            return Ok(result);
        }
    }
}
