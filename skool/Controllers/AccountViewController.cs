using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using skool.DAL;
using skool.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace skool.Controllers
{
    public class AccountViewController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: AccountView
        public ActionResult Index()
        {
            return View(db.AccountViewModels.ToList());
        }

        // GET: AccountView/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountViewModels accountViewModels = db.AccountViewModels.Find(id);
            if (accountViewModels == null)
            {
                return HttpNotFound();
            }
            return View(accountViewModels);
        }

        // GET: AccountView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountView/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Email,Password,ConfirmPassword,Name")] AccountViewModels accountViewModels)
        {
            if (ModelState.IsValid)
            {
                db.AccountViewModels.Add(accountViewModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountViewModels);
        }

        // GET: AccountView/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountViewModels accountViewModels = db.AccountViewModels.Find(id);
            if (accountViewModels == null)
            {
                return HttpNotFound();
            }
            return View(accountViewModels);
        }

        // POST: AccountView/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Email,Password,ConfirmPassword,Name")] AccountViewModels accountViewModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountViewModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accountViewModels);
        }

        // GET: AccountView/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountViewModels accountViewModels = db.AccountViewModels.Find(id);
            if (accountViewModels == null)
            {
                return HttpNotFound();
            }
            return View(accountViewModels);
        }

        // POST: AccountView/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountViewModels accountViewModels = db.AccountViewModels.Find(id);
            db.AccountViewModels.Remove(accountViewModels);
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
