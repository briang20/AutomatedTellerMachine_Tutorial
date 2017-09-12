using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //Get /home/index
        [MyLoggingFilter]
        public ActionResult Index()
        {
            return View();
        }

        //Get /home/about
        [ActionName("about-this-atm")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message!";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }
    }
}