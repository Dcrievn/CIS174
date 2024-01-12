using FirstResponsiveWebAppDam.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppDam.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(AgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Age = 0;
            }
            return View(model);
        }
    }
}

