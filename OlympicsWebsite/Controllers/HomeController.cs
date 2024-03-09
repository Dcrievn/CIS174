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
        public IActionResult Index(CountryListViewModel model)
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(model.ActiveGame);
            session.SetActiveSport(model.ActiveSportType);

            // if no count in session, get cookie and restore fave teams in session
            int? count = session.GetMyCountryCount();
            if (count == null)
            {
                var cookies = new OlympicCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();
                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                {
                    mycountries = context.Countries.Include(c => c.Game)
                    .Include(c => c.Sport)
                    .Where(t => ids.Contains(t.CountryID)).ToList();
                }
                session.SetMyCountries(mycountries);
            }

            model.Games = context.Games.ToList();
            model.Sports = context.Sports.ToList();

            IQueryable<Country> query = context.Countries;

            if (model.ActiveGame != "all")
                query = query.Where(c => c.Game.GameID.ToLower() == model.ActiveGame.ToLower());
            if (model.ActiveSportType != "all")
                query = query.Where(c => c.Sport.SportID.ToLower() == model.ActiveSportType.ToLower());

            // pass countries to view as model
            model.CountryList = query.ToList();
            return View(model);
        }
        //public ViewResult Index(string activeGame = "all", string activeSportType = "all")
        //{
        //    var session = new OlympicSession(HttpContext.Session);
        //    session.SetActiveGame(activeGame);
        //    session.SetActiveSport(activeSportType);

        //    // if no count in session, get cookie and restore fave teams in session
        //    int? count = session.GetMyCountryCount();
        //    if (count == null)
        //    {
        //        var cookies = new OlympicCookies(Request.Cookies);
        //        string[] ids = cookies.GetMyCountryIds();
        //        List<Country> mycountries = new List<Country>();
        //        if (ids.Length > 0)
        //        {
        //            mycountries = context.Countries.Include(c => c.Game)
        //            .Include(c => c.Sport)
        //            .Where(t => ids.Contains(t.CountryID)).ToList();
        //        }
        //        session.SetMyCountries(mycountries);
        //    }

        //    var model = new CountryListViewModel
        //    {
        //        ActiveGame = activeGame,
        //        ActiveSportType = activeSportType,
        //        Games = context.Games.ToList(),
        //        Sports = context.Sports.ToList()
        //    };

        //    IQueryable<Country> query = context.Countries;
        //    if (activeGame != "all")
        //        query = query.Where(c => c.Game.GameID.ToLower() == activeGame.ToLower());
        //    if (activeSportType != "all")
        //        query = query.Where(c => c.Sport.SportID.ToLower() == activeSportType.ToLower());

        //    // pass countries to view as model
        //    model.CountryList = query.ToList();
        //    return View(model);
        //}
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
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
            .Include(c => c.Game)
            .Include(c => c.Sport)
            .FirstOrDefault(c => c.CountryID == id),
                ActiveGame = session.GetActiveGame(),
                ActiveSportType = session.GetActiveSport()
            };
            return View(model);
        }
        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
            .Include(c => c.Game)
            .Include(c => c.Sport)
            .Where(c => c.CountryID == model.Country.CountryID)
            .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
            new
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport()
            });
        }
    }
}
