using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Business;


namespace ISEM551project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Message = "Your privacy page.";

            return View();
        }
        public ActionResult Resorts()
        {
            ViewBag.Message = "Resorts page.";
            var IndivResort = resort.GetIndividualResortInfo();


            return View(IndivResort);
        }
    }
}