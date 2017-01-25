using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Admin.Web.Controllers
{
    public class ElementsController : Controller
    {
        // GET: Elements
        public ActionResult IconsFont()
        {
            return View();
        }

        public ActionResult IconsWeather()
        {
            return View();
        }
        public ActionResult SweetAlert()
        {
            return View();
        }
        public ActionResult Notifications()
        {
            return View();
        }
        public ActionResult NProgress()
        {
            return View();
        }
    }
}