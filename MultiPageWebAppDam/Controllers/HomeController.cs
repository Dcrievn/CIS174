using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiPageWebAppDam.Models;

namespace MultiPageWebAppDam.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            // sorts contacts by first letter of name
            var contact = context.Contacts.OrderBy(c => c.Name).ToList();
            return View(contact);
        }
    }
}
