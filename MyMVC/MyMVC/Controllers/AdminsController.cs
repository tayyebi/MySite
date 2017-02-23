using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebInterface.Controllers;

namespace MyMVC.Controllers
{

    public partial class AdminsController : Controller
    {
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Where(x => x.Username == id).FirstOrDefault();
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }
    }

    public partial class AdminsController : Controller
    {
        private DcDataContext db = new DcDataContext();
        // GET: Admins/Details/5

        // GET: Admins
        [Secure]
        public ActionResult Index()
        {
            return View(db.Admins.ToList());
        }

        // GET: Admins/Create
        [Secure]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Secure]
        public ActionResult Create([Bind(Include = "Username,Password,Fullname")] Admin admin)
        {
            try
            {
                db.AdminInsertCommand(admin.Username, admin.Password, admin.Fullname);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Warning = "خطا در اضافه کردن ادمین به سیستم";
                return View(admin);
            }

        }

        // GET: Admins/Edit/5
        [Secure]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Where(x => x.Username == id).FirstOrDefault();
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        [Secure]
        public ActionResult Edit([Bind(Include = "Username,Password,Fullname")] Admin admin)
        {
            try
            {
                db.AdminUpdateCommand(admin.Username, admin.Password, admin.Fullname, admin.Username);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(admin);
            }
        }
        // GET: Admins/Delete/5
        [Secure]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Where(x => x.Username == id).FirstOrDefault();
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]

        [Secure]
        public ActionResult DeleteConfirmed(string id)
        {
            db.AdminDeleteCommand(id);
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
