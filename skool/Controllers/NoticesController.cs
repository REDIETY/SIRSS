﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using skool.DAL;
using skool.Models;

namespace skool.Controllers
{
    public class NoticesController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Notices
        public ActionResult Index()
        {
            var P = db.Notices.ToList();
            return View(P);
           
        }

        // GET: Notices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notices notices = db.Notices.Find(id);
            if (notices == null)
            {
                return HttpNotFound();
            }
            return View(notices);
        }

        // GET: Notices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,description")] Notices notices)
        {
            if (ModelState.IsValid)
            {
                db.Notices.Add(notices);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notices);
        }

        // GET: Notices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notices notices = db.Notices.Find(id);
            if (notices == null)
            {
                return HttpNotFound();
            }
            return View(notices);
        }

        // POST: Notices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,description")] Notices notices)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notices).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notices);
        }

        // GET: Notices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notices notices = db.Notices.Find(id);
            if (notices == null)
            {
                return HttpNotFound();
            }
            return View(notices);
        }

        // POST: Notices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notices notices = db.Notices.Find(id);
            db.Notices.Remove(notices);
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
