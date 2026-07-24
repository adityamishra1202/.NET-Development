using _21_July.Models;
using _21_July.Views.Home;
using Microsoft.AspNetCore.Mvc;

namespace _21_July.Controllers
{
    public class HomeController : Controller
    {
        // Display Form
        public ActionResult Register()
        {
            return View();
        }

        // Handle Form Submission
        [HttpPost]
        public ActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                TempData["StudentName"] = student.name;
                return RedirectToAction("Schedule");
            }

            return View(student);
        }

        // Course Schedule Page
        public ActionResult Schedule()
        {
            List<Course> course = new List<Course>()
            {
                new Course
                {
                    courseName = "asp.net",
                    sem = "sem 3",
                    sessionTime = "9.30am - 12.00pm",
                    days = "Mon - tue"
                },

                new Course
                {
                    courseName = "java",
                    sem = "sem 3",
                    sessionTime = "9.30am - 11.00am",
                    days = "tue - wed"
                },

                new Course
                {
                    courseName = "html",
                    sem = "sem 3",
                    sessionTime = "9.30am - 11.00am",
                    days = "fri - sat"
                }
            };

            return View(course);
        }
    }
}
