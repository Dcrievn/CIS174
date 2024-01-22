using Microsoft.AspNetCore.Mvc;
using MultiPageWebAppDam.Models;

namespace MultiPageWebAppDam.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        
        // Allows the usage of adding new contacts
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new ContactInfo());
        }

        // Allows editing of contacts
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Edit(ContactInfo contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactID == 0)
                    context.Contacts.Add(contact);
                else
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.ContactID == 0) ? "Add" : "Edit";
                return View(contact);
            }
        }

        // allows deleting contacts
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(ContactInfo contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
