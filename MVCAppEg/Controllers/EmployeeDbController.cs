using MVCAppEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppEg.Controllers
{
    public class EmployeeDbController : Controller
    {
        IBM06Aug25DbEntities _db = new IBM06Aug25DbEntities();



        // GET: EmployeeDb
        public ActionResult Index()
        {

            return View(_db.Employees.ToList());
        }

        // GET: EmployeeDb/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeDb/Create
        public ActionResult Create()
        {
            ViewBag.DeptID = _db.Depts.Select(s => new SelectListItem { Text=s.DeptName , Value = s.DeptID.ToString() });


            return View();




        }

        // POST: EmployeeDb/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here

                var s = _db.Entry(emp).State;



                _db.Employees.Add(emp);
                _db.SaveChanges();



                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.DeptID = _db.Depts.Select(s => new SelectListItem { Text = s.DeptName, Value = s.DeptID.ToString() });


                return View(emp);
            }
        }

        // GET: EmployeeDb/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = _db.Employees.Find(id);

            ViewBag.DeptID = _db.Depts.Select(s => new SelectListItem { Text = s.DeptName, Value = s.DeptID.ToString() });

            return View(obj);
        }

        // POST: EmployeeDb/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee  emp)
        {
            try
            {
                // TODO: Add update logic here

                _db.Entry(emp).State= System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeDb/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeDb/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
