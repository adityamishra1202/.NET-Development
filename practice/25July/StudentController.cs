using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _25July.Models;

namespace _25July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       
            private static List<Student> students = new List<Student>()
        {
            new Student
            {
                id = 1,
                Name = "Ram",
                Age = 19,
                Department = "Computer Science"
            },
            new Student
            {
                id = 2,
                Name = "Lakshman",
                Age = 20,
                Department = "Information Technology"
            },
            new Student
            {
                id = 3,
                Name = "Abhijeet",
                Age = 20,
                Department = "Mechanical"
            },
            new Student
            {
                id = 4,
                Name = "Ayush",
                Age = 21,
                Department = "Electronics"
            }
        };

            // GET: api/Student
            [HttpGet]
            public ActionResult GetStudents()
            {
                return Ok(students);
            }
        [HttpGet("{id}")] // fetch student based on ID
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
        [HttpPost] // add new student in existing student list
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);

            return CreatedAtAction(nameof(GetStudent),
                new { id = student.id }, student);
        }
        [HttpPut("{id}")] // edit or modify existing student data based on id
        public IActionResult UpdateStudent(int id, Student updateStudent)
        {
            var student = students.FirstOrDefault(s => s.id == id);

            if (student == null)
            {
                return NotFound();
            }

            student.Age = updateStudent.Age;

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.id == id);

            if (student == null)
            {
                return NotFound(); // 404
            }

            students.Remove(student);

            return NoContent(); // 204
        }
    }
    }
