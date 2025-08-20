using MVCAppEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppEg.Controllers
{
    public class RazorViewEngineController : Controller
    {

        Models.IBM06Aug25DbEntities _db = new Models.IBM06Aug25DbEntities();



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


        public ActionResult ValidationAndHTMLHelpersContent()
        {
            ViewBag.DeptID = new SelectList(_db.Depts, "DeptID", "DeptName"); 


            return View();
        }


        [HttpPost]
        public ActionResult ValidationAndHTMLHelpersContent(Employee obj)
        {

            if (obj.FirstName.Length<=5)
            {
                     ModelState.AddModelError("FirstName", "Min Len must be above 5 Char");
            }
   



            if (ModelState.IsValid) {


                return RedirectToAction("index");

            
            }


            ViewBag.DeptID = new SelectList(_db.Depts, "DeptID", "DeptName");


            return View();
        }

    }
}