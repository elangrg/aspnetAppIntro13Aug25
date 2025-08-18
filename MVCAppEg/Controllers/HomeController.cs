using MVCAppEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppEg.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("_index");



        }


        // contentresult
        public ContentResult SayHiCR()
        {
            return Content( "Hi Stranger");
        }


        // contentresult
        public string SayHi()
        {
            return "Hi Stranger";
        }

        // contentresult
        public Employee GetEmployee()
        {
            return new Employee { EmpID=1000, EmpName="Ganesh" };
        }

        // Emptyresult
        public void SayNothing()
        {
            return ;
        }

        [NonAction]

        public void Internalusage()
        {
            return;
        }

        public ActionResult RedirectResultEg()
        {
            return RedirectToAction("index","Employee");
        }


        public ActionResult RedirectEg()
        {
            return Redirect("~/home/GetEmployee");
        }


    }
}