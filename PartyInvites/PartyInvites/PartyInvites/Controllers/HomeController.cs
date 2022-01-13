using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            string greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            ViewBag.Greeting = greeting;

            return View();
        }
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RsvpForm(Guest guest)
        {
            Repository.AddResponse(guest);
            return View("Thanks", guest);
        }

        public ActionResult ListResponses()
        {
            return View(Repository.Responses.Where(r=>r.WillAttend==true));
        }
    }
}
