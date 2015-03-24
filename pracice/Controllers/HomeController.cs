using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pracice.Controllers
{
    public class HomeController : Controller
    {
        public NORTHWNDEntities db = new NORTHWNDEntities();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(db.Orders);
        }
    }
}
