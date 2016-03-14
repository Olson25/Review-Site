using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class ReviewController : Controller
    {
        private ReviewDB db = new ReviewDB();

        //
        // GET: /Review/

        public ActionResult Index()
        {
            return View(db.reviews.ToList());
        }

        //
        // GET: /Review/Details/5

        public ActionResult Details(int id = 0)
        {
            Review review = db.reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        //
        // GET: /Review/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Review/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                db.reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(review);
        }

        //
        // GET: /Review/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Review review = db.reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }
        public ActionResult FilterbyGame(int id = 0)
        {
            return View(db.reviews.ToList());
        }

        //
        // POST: /Review/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        //
        // GET: /Review/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Review review = db.reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        //
        // POST: /Review/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.reviews.Find(id);
            db.reviews.Remove(review);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}