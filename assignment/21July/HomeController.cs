using System.Diagnostics;
using _21_July_Assign.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21_July_Assign.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            if(ModelState.IsValid)
            {
                TempData["emp"] = employee.Employee_Name;
                TempData["dep"] = employee.Department;
                return RedirectToAction("Department");

            }
            return View(employee);
        }

        public IActionResult Department()
        {
            List<Department> departments = new List<Department>()
            {
             new Department{Department_Name="HR",Department_Head="Kiran Wadatkar",Contact_No=6788998765,Email="kiran@1234" },
              new Department{Department_Name="QC",Department_Head="Vedant Tayde",Contact_No=9988998765,Email="vedant@1234" },
               new Department{Department_Name="Logistics",Department_Head="V.R. Kannan",Contact_No=9988576748,Email="kannan@1234" },
                new Department{Department_Name="HRM",Department_Head="Sanjay Singh",Contact_No=9878899675,Email="sanjay@1234" },
                 new Department{Department_Name="CRM",Department_Head="Jay Ghosh",Contact_No=9284775234,Email="jay@1234" },





            };
                return View(departments);
 }

    }

}
