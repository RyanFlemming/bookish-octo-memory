using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.HomePage = "You've reached the home page.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.DescriptionPage = "About your page.";
            return View();
        }

        public ActionResult Contact()
        {
            Person importantPerson = new Person
            {
                FirstName = "Ryan",
                LastName = "Flemming",
                EmailAddress = "thisprogrammingstuffisfun@programmingallday.com"
            };

            ViewData["APerson"] = importantPerson;
            return View();
        }
    }
}