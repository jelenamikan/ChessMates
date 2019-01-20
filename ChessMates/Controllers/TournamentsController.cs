using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ChessMates.Models;

namespace ChessMates.Controllers
{
    public class TournamentsController : Controller
    {
        private AppDatabase db = new AppDatabase();

        // GET: Tournaments
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.Admin))
            {
                return View("AdminIndex");
            }
            return View("GuestIndex");
        }

        // GET: Tournaments/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return HttpNotFound();
            }
            return View(tournament);
        }

        // GET: Tournaments/Create
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Create()
        {
            ViewBag.isoAlpha3 = new SelectList(db.Countries, "isoAlpha3", "countryName");
            return View();
        }

        // POST: Tournaments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Create([Bind(Include = "Id,Name,StartDate,EndDate,City,Type,isoAlpha3")] Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                db.Tournaments.Add(tournament);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.isoAlpha3 = new SelectList(db.Countries, "isoAlpha3", "countryName", tournament.isoAlpha3);
            return View(tournament);
        }

        // GET: Tournaments/Edit/5
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return HttpNotFound();
            }
            ViewBag.isoAlpha3 = new SelectList(db.Countries, "isoAlpha3", "countryName", tournament.isoAlpha3);
            return View(tournament);
        }

        // POST: Tournaments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Edit([Bind(Include = "Id,Name,StartDate,EndDate,City,Type,isoAlpha3")] Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tournament).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.isoAlpha3 = new SelectList(db.Countries, "isoAlpha3", "countryName", tournament.isoAlpha3);
            return View(tournament);
        }

        // GET: Tournaments/Delete/5
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return HttpNotFound();
            }
            return View(tournament);
        }

        // POST: Tournaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult DeleteConfirmed(long id)
        {
            Tournament tournament = db.Tournaments.Find(id);
            db.Tournaments.Remove(tournament);
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
