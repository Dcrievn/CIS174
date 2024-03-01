using Microsoft.AspNetCore.Mvc;
using OlympicsWebsite.Models;

namespace OlympicsWebsite.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSportType = session.GetActiveSport(),
                CountryList = session.GetMyCountries()
            };
            return View(model);
        }
        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            var cookies = new OlympicCookies(Response.Cookies);

            session.RemoveMyCountry();
            cookies.RemoveMyCountryIds();

            TempData["message"] = "Favorite teams cleared";
            return RedirectToAction("Index", "Home",
            new
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSportType = session.GetActiveSport()
            });
        }
    }
}
