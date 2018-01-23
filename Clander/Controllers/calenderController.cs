using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clander.ViewModel;

namespace Clander.Controllers
{
    public class calenderController : Controller
    {
        // GET: calander
        public ActionResult Index()
        {
            return View();
        }

        // GET: calander/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: calander/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: calander/Create
        [HttpPost]
        public ActionResult Create(Clandertest collection)
        {
         

            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: calander/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: calander/Edit/5
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

        // GET: calander/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: calander/Delete/5
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
