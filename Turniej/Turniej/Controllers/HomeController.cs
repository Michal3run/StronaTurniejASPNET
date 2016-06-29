using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Turniej.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Strona o mnie";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Strona Kontaktowa";

            return View();
        }

        public ActionResult MoreInfo()
        {
            ViewBag.Message = "Dodatkowe informacje";

            return View();
        }

    }
}