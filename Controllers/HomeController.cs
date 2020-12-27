using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace koronamorona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Günlük Veriler.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Covid hakkında yapılması gerekenler.";

            return View();
        }
    }
}