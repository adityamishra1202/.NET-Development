using System.Diagnostics;
using _22_July.Models;
using Microsoft.AspNetCore.Mvc;

namespace _22_July.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //display form
        public IActionResult Index()
        {
            return View();
        }


        //receive form data

        [HttpPost]
        public ActionResult Index(Product product)
        {
            if (ModelState.IsValid)
            {
                //normally save to db
                return Content($"Product: {product.Name}, " +
                    $"Price: {product.Price}, " +
                    $"Category: {product.Category}, " +
                    $"Stock: {product.Stock}");
            }

            return View(product);


        }

        public IActionResult Stationary()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Stationary(Stationary st)
        {
            if (ModelState.IsValid)
            {
                //normally save to db
                return Content($"Product: {st.Name}, " +
                    $"Price: {st.Price}, " +
                    $"Brand: {st.Brand}, " +
                    $"Stock: {st.stock}");
            }

            return View(st);


        }

    }
}
