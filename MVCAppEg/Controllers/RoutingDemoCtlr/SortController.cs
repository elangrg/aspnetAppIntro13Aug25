using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppEg.Controllers.RoutingDemoCtlr
{
    public class SortController : Controller
    {
        // GET: Sort
        public ActionResult Index(string values, string id)
        {
            var brokenValues = values.Split('/');
            Array.Sort(brokenValues);
            return Content(String.Join(", ", brokenValues));
        }
    }
}