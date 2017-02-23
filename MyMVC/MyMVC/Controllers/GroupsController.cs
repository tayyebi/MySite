using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebInterface.Controllers;

namespace MyMVC.Controllers
{
    public partial class GroupsController : Controller
    {
        public ActionResult Feed()
        {
            return PartialView(db.Groups.ToList());
        }
        // GET: Groups/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Groups.Where(x => x.Id == id).FirstOrDefault();
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

    }
    public partial class GroupsController : Controller
    {
        DcDataContext db = new DcDataContext();



        // GET: Groups
        [Secure]
        public ActionResult Index()
        {
            return View(db.Groups.ToList());
        }


        // GET: Groups/Create
        [Secure]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        [Secure]
        public ActionResult Create([Bind(Include = "Id,Title")] Group group)
        {
            if (ModelState.IsValid)
            {
                group.Id = Guid.NewGuid();
                return RedirectToAction("Index");
            }

            return View(group);
        }

        // GET: Groups/Edit/5
        [Secure]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Groups.Where(x => x.Id == id).FirstOrDefault();
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        [Secure]
        public ActionResult Edit([Bind(Include = "Id,Title")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.GroupUpdateCommand(group.Id, group.Title, group.Id);
                return RedirectToAction("Index");
            }
            return View(group);
        }

        // GET: Groups/Delete/5
        [Secure]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Groups.Where(x => x.Id == id).FirstOrDefault();
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]

        [Secure]
        public ActionResult DeleteConfirmed(Guid id)
        {
            db.GroupDeleteCommand(id);
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
