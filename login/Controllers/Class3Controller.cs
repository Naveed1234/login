using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using login.Models;

namespace login.Controllers
{
    public class Class3Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Class3
        public ActionResult Index()
        {
            return View(db.Class3.ToList());
        }

        // GET: Class3/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class3 class3 = db.Class3.Find(id);
            if (class3 == null)
            {
                return HttpNotFound();
            }
            return View(class3);
        }

        // GET: Class3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] Class3 class3)
        {
            if (ModelState.IsValid)
            {
                db.Class3.Add(class3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(class3);
        }

        // GET: Class3/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class3 class3 = db.Class3.Find(id);
            if (class3 == null)
            {
                return HttpNotFound();
            }
            return View(class3);
        }

        // POST: Class3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] Class3 class3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(class3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(class3);
        }

        // GET: Class3/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class3 class3 = db.Class3.Find(id);
            if (class3 == null)
            {
                return HttpNotFound();
            }
            return View(class3);
        }

        // POST: Class3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Class3 class3 = db.Class3.Find(id);
            db.Class3.Remove(class3);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
