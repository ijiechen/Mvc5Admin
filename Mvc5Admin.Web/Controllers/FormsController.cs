using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Admin.Web.Controllers
{
    public class FormsController : Controller
    {
        // GET: Tables
        public ActionResult FormStandard()
        {
            return View();
        }
        public ActionResult FormExtended()
        {
            return View();
        }
    }
}