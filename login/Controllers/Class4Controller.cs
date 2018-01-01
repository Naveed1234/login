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
    public class Class4Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Class4
        public ActionResult Index()
        {
            return View(db.Class4.ToList());
        }

        // GET: Class4/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class4 class4 = db.Class4.Find(id);
            if (class4 == null)
            {
                return HttpNotFound();
            }
            return View(class4);
        }

        // GET: Class4/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class4/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] Class4 class4)
        {
            if (ModelState.IsValid)
            {
                db.Class4.Add(class4);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(class4);
        }

        // GET: Class4/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class4 class4 = db.Class4.Find(id);
            if (class4 == null)
            {
                return HttpNotFound();
            }
            return View(class4);
        }

        // POST: Class4/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] Class4 class4)
        {
            if (ModelState.IsValid)
            {
                db.Entry(class4).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(class4);
        }

        // GET: Class4/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class4 class4 = db.Class4.Find(id);
            if (class4 == null)
            {
                return HttpNotFound();
            }
            return View(class4);
        }

        // POST: Class4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Class4 class4 = db.Class4.Find(id);
            db.Class4.Remove(class4);
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
