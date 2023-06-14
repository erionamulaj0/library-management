using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryMengament.Models;

namespace LibraryMengament.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private LibraryMenagmentEntities db = new LibraryMenagmentEntities();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.lcategories.ToList());
        }

        // GET: Category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lcategory lcategory = db.lcategories.Find(id);
            if (lcategory == null)
            {
                return HttpNotFound();
            }
            return View(lcategory);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,catname,status")] lcategory lcategory)
        {
            if (ModelState.IsValid)
            {
                db.lcategories.Add(lcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lcategory);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lcategory lcategory = db.lcategories.Find(id);
            if (lcategory == null)
            {
                return HttpNotFound();
            }
            return View(lcategory);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,catname,status")] lcategory lcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lcategory);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lcategory lcategory = db.lcategories.Find(id);
            if (lcategory == null)
            {
                return HttpNotFound();
            }
            return View(lcategory);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            lcategory lcategory = db.lcategories.Find(id);
            db.lcategories.Remove(lcategory);
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
