using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Admin.Web.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Extras()
        {
            return View();
        }
    }
}