using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC_ex.Controllers
{
    public class DryController : Controller
    {
        public ActionResult HelperInPage()
        {
            return View();
        }

        public ActionResult HelperInAppCode()
        {
            return View();
        }

        public ActionResult PartialViews()
        {
            return View();
        }

        public ActionResult PartialPagesIllustration()
        {
            return View();
        }
    }
}