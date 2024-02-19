using Microsoft.AspNetCore.Mvc;
using RazorWebsite.Models;

namespace RazorWebsite.Controllers
{
    public class AssignmentController : Controller
    {
        [Route("[controller]/[action]/{accessLevel}")]
        public ActionResult Index(int accessLevel)
        {
            var students = new List<Student>
            {
                new Student { FirstName = "Eric", LastName = "Dam", Grade = 100 },
                new Student { FirstName = "Joe", LastName = "Smith", Grade = 30 },
                new Student { FirstName = "Bob", LastName = "Johnson", Grade = 78 },
            };
            var viewModel = new AssignmentViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View("Index", viewModel);
        }
    }
}
