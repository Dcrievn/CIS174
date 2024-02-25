using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OlympicsWebsite.Models;
using System.Diagnostics;

namespace OlympicsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;
        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index(string activeGame = "all", string activeSportType = "all")
        {
            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveSportType = activeSportType,
                Games = context.Games.ToList(),
                Sports = context.Sports.ToList()
            };
            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(c => c.Game.GameID.ToLower() == activeGame.ToLower());
            if (activeSportType != "all")
                query = query.Where(c => c.Sport.SportID.ToLower() == activeSportType.ToLower());

            // pass countries to view as model
            model.CountryList = query.ToList();
            return View(model);
        }
        [HttpPost]
        public RedirectToActionResult Details(CountryViewModel model)
        {
            //Utility.LogCountryClick(model.Country.CountryID);
            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveSportType"] = model.ActiveSportType;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }
        [HttpGet]
        public ViewResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries.Include(c => c.Sport).Include(c => c.Game).FirstOrDefault(c => c.CountryID == id),
                ActiveGame = TempData?["ActiveGame"]?.ToString() ?? "all",
                ActiveSportType = TempData?["ActiveSportType"]?.ToString() ?? "all"
            };
            return View(model);
        }
    }
}
