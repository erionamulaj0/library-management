using LibraryMengament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMengament.Controllers
{
    [Authorize]
    public class IssueBookController : Controller
    {
        LibraryMenagmentEntities db = new LibraryMenagmentEntities();
        // GET: IssueBook
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getbook()
        {
            var books = db.books.Select(p => new
            {

                ID = p.id,
                Bname = p.bname,

            }).ToList();
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetMid(int mid)
        {
            var memberid = (from s in db.members where s.id == mid select s.name).ToList();
            return Json(memberid,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(issuebook issue)
        {
            if (ModelState.IsValid)
            {
                db.issuebooks.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
        }


    }
}