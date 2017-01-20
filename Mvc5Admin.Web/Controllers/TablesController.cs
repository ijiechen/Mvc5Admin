using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Admin.Web.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public ActionResult TableStandard()
        {
            return View();
        }
    }
}