using System.Diagnostics;
using _16_JULY.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16_JULY.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Id = 101,
                    Name = "Sharan",
                    Age = 50,
                    Course = "Java Framework",
                Gender='M',
                Qualification="UG",
                Fees=90000},
                new Student
                {
                    Id = 102,
                    Name = "Karam",
                    Age = 51,
                    Course = "Java Framework",
                Gender='M',
                Qualification="PG",
                Fees=100000}

            };

            return View(students);
        }
    }
}
