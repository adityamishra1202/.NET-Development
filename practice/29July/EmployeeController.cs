using _29_July.Models;
using _29_July.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _29_July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;   // read only service variable

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getEmployees());
        }

        [HttpGet("{deptid}")]
        public IActionResult GetById(int deptid)
        {
            var employee = _service.getEmployeee(deptid);

            if (employee == null)
            {
                return NotFound("Employee with id not found");
            }

            return Ok(employee);
        }

        [HttpGet("Name/{name}")]
        public IActionResult GetByName(string name)
        {
            var employee = _service.getEmployeeName(name);

            if (employee == null)
            {
                return NotFound("Employee with name not found");
            }

            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var res = _service.addEmployee(employee);

            return Ok(res);
        }
    }
}
