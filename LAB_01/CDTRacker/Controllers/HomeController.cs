using CDTRacker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDTRacker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CDForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CDForm(CD cd)
        {
            return View();
        }

    }
}
