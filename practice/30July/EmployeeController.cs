using _30_July_Assign.Models;
using _30_July_Assign.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30_July_Assign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service) {
            _service = service;
     }
        [HttpGet]   
        public IActionResult GetEmployees()
        {
            var result = _service.GetEmployee();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var result = _service.GetEmployeeById(id);
            if(result == null)
            {
                return BadRequest("No employee found");

            }
            return Ok(result);
        }
        [HttpGet("Name{namee}")]
        public IActionResult GetEmployeeByName(string name)
        {
            var result = _service.GetEmployeeByName(name);
            if (result == null)
            {
                return BadRequest("No employee found");

            }
            return Ok(result);
        }
        [HttpGet("Department{deptt}")]
        public IActionResult GetEmployeeByDepartment(string dept)
        {
            var result = _service.SearchEmployeeByDepartment(dept);
            if (!result.Any()) { return NotFound("Not employee found under this dept"); }
            return Ok(result);
        }
        [HttpGet("email{mail}")]
        public IActionResult GetEmployeeByEmail(string mail)
        {
            var result = _service.SearchEmployeeByEmail(mail);
            if (result == null)
            {
                return BadRequest("No employee found");
            }
            return Ok(result);
        }
        [HttpGet("Status/{status}")]
        public IActionResult GetEmployeeByStatus(string status)
        {
            var result = _service.SearchEmployeeByStatus(status);
            if (!result.Any()) { return NotFound("Not employee found under this dept"); }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            bool answer=_service.DeleteEmployee(id);
            if (answer)
            {
                return Ok("yes found and delted");
            }
            return BadRequest("Not found");

        }
        [HttpPost]
        public ActionResult AddEmployee( Employee emp)
        {
            var result= _service.CreateEmployee( emp);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateEmployee(int id,Employee emp)
        {
            var result = _service.UpdateEmployee(id,emp);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        
    }
}
