using Microsoft.AspNetCore.Mvc;

namespace MultiPageWebAppDam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [Route("[area]/")]
        public IActionResult IndexOverride()
        {
            return Content("Index Override");
        }
    }
}
