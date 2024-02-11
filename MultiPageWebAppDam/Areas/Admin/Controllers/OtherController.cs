using Microsoft.AspNetCore.Mvc;

namespace MultiPageWebAppDam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OtherController : Controller
    {
        [Route("[area]/Custom/[controller]/[action]")]
        public IActionResult Index()
        {
            return Content("Other Controller!");
        }
    }
}
