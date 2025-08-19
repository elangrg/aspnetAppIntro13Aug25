using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppEg.Controllers
{
    public class RazorViewEngineController : Controller
    {
        // GET: RazorViewEngine
        public ActionResult BasicSyntaxIntro()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }




        public ActionResult SimpleLayoutContent()
        {
            return View();
        }


        public ActionResult NestedLayoutContent()
        {
            return View();
        }

    }
}