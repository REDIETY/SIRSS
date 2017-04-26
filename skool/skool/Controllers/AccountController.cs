using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using skool.Models;
using skool.DAL;
using skool.ViewModels;

namespace skool.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            return View(db.useraccount.ToList());
         
        }
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(useraccount account)
        {
            if (ModelState.IsValid)
            {
                using (SchoolContext db = new SchoolContext())
                {
                    db.useraccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.firstName + "" + account.MiddleName + "successfully registerd.";
            }
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(useraccount user)
        {
            using (SchoolContext db = new SchoolContext())
            {
                var usr = db.useraccount.Single(u => u.UserName == user.UserName && u.password == user.password);
                if (usr != null)
                {
                    Session["userId"] = usr.userId.ToString();
                    Session["UserName"] = usr.UserName.ToString();
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("", "username or password is wrong");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["userId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}