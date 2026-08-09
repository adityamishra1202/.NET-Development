using _30_July_Assign.Services;
using _30_July_Assign.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30_July_Assign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _service;
        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var result = _service.ShowDepartments();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public ActionResult GetDepartmentByID(int id)
        {
            var result = _service.GetDepartment(id);
            if(result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            var result=_service.AddDepartment(department);  
            if(result == null)
            {
                return BadRequest("Department Already Exists");
            }
            return Ok(result);
        }
        [HttpPut]
        public ActionResult UpdateDepartment(int id,Department department)
        {
            var result= _service.UpdateDepartment(id, department);  
            if(result == null)
            {
                return BadRequest("Department Already Exists");
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteDepartment(int id)
        {

            bool result= _service.DeleteDepartment(id);
            if (result)
            {
                return Ok("Yes deleted");

            }
            return BadRequest("No it contains the employees");






        }


    }
    
}