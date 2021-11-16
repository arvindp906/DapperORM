using DapperORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DapperORM.Controllers
{
    public class vegetablesController : Controller
    {
        VegetableRepository repo = new VegetableRepository();

        // GET: vegetables
        public ActionResult Index()
        {
            return View(repo.Vegetable_ViewAll());
        }

        // GET: vegetables/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: vegetables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vegetables/Create
        [HttpPost]
        public ActionResult Create(Vegetable veg)
        {
            try
            {
                // TODO: Add insert logic here
                repo.Vegetable_Add(veg);
                ViewBag.Message = "Records added successfully.";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: vegetables/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repo.Vegetable_Update(Vegetable).Find(Emp => Emp.Empid == id));

           
        }

        // POST: vegetables/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: vegetables/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: vegetables/Delete/5
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
