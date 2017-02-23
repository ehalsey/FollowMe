using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FollowMe.Controllers
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
        public ActionResult Marketplace()
        {
            ViewBag.Message = "Your marketplace page.";

            return View();
        }

        public ActionResult Subscriptions()
        {
            ViewBag.Message = "Your subscriptions page.";

            return View();
        }

        public ActionResult StreamingNow()
        {
            ViewBag.Message = "Your streaming now page.";

            return View();
        }
    }
}