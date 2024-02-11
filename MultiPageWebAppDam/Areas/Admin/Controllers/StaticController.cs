using Microsoft.AspNetCore.Mvc;

namespace MultiPageWebAppDam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StaticController : Controller
    {
        [Route("[area]/static")]
        public IActionResult StaticContent(string num)
        {
            return Content($"Static Content: {num}");
        }
    }
}
