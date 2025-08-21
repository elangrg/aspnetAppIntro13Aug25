using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppEg.Controllers.RoutingDemoCtlr
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Insert()
        {
            return View();
        }
    }
}