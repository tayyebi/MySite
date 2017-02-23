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
    public partial class PostsController : Controller
    {
        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }
    }

    public partial class PostsController : Controller
    {
        private DcDataContext db = new DcDataContext();

        // GET: Posts
        [Secure]
        public ActionResult Index()
        {
            var post = db.Posts;
            return View(post.ToList());
        }
        // GET: Posts/Create
        [Secure]
        public ActionResult Create()
        {
            ViewBag.AdminUsername = new SelectList(db.Admins, "Username", "Password");
            ViewBag.GroupId = new SelectList(db.Groups, "Id", "Title");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        [ValidateInput(false)]
        [Secure]
        public ActionResult Create([Bind(Include = "Id,Title,Date,Abstract,Body,AdminUsername,GroupId")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.PostInsertCommand(post.Title, DateTime.Now, post.Abstract, post.Body, Session["Username"].ToString(), post.GroupId);
                return RedirectToAction("Index");
            }

            ViewBag.AdminUsername = new SelectList(db.Admins, "Username", "Password", post.AdminUsername);
            ViewBag.GroupId = new SelectList(db.Groups, "Id", "Title", post.GroupId);
            return View(post);
        }



        // GET: Posts/Edit/5
        [Secure]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (post == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdminUsername = new SelectList(db.Admins, "Username", "Password", post.AdminUsername);
            ViewBag.GroupId = new SelectList(db.Groups, "Id", "Title", post.GroupId);
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        [Secure]
        public ActionResult Edit([Bind(Include = "Id,Title,Date,Abstract,Body,AdminUsername,GroupId")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.PostUpdateCommand(post.Title, post.Date, post.Abstract, post.Body, Session["Username"].ToString(), post.GroupId, post.Id, post.Id);
                return RedirectToAction("Index");
            }
            ViewBag.AdminUsername = new SelectList(db.Admins, "Username", "Password", post.AdminUsername);
            ViewBag.GroupId = new SelectList(db.Groups, "Id", "Title", post.GroupId);
            return View(post);
        }

        // GET: Posts/Delete/5
        [Secure]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [Secure]
        public ActionResult DeleteConfirmed(int id)
        {
            db.PostDeleteCommand(id);
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