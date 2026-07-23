using System.Diagnostics;
using _22_July_Assign.Models;
using Microsoft.AspNetCore.Mvc;

namespace _22_July_Assign.Controllers
{
    public class HomeController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }


        //receive form data

        [HttpPost]
        public ActionResult Index(Automobile at)
        {
            if (ModelState.IsValid)
            {
                //normally save to db
                //return Content($"vehicle Name: {at.Vehicle_Name}, " +
                //    $"Breand: {at.Brand}, " +
                //    $"Model Year: {at.Model_Year}, " +
                //    $"Price: {at.Price},"+
                //    $"Fuel Type:{at.FuelType}");
                TempData ["Victory"] = "Automobile Registered Successfully";
                TempData["VehicleName"] = at.Vehicle_Name;
                TempData["Brand"] = at.Brand;
                return RedirectToAction("Manufacture");

            }

            return View(at);


        }
        public IActionResult Manufacture()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult Manufacture(Manufacture man)
        {
            
            return View(man);
        }



    }
}
