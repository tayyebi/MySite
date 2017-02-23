using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        DcDataContext dc = new DcDataContext();
        public ActionResult Index()
        {
            var Oo = dc.Posts.OrderByDescending(x => x.Date).Take(4).ToList();
            // var Oo = dc.Posts.Select(y => new Post { Title = y.Title, Date = y.Date, Id = y.Id, AdminUsername = y.AdminUsername, Abstract = y.Abstract, GroupId = y.GroupId }).OrderByDescending(x => x.Date).Take(4).ToList();
           
            return View(Oo);
        }

        public ActionResult Login()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            string log = new Models.DcDataContext().Login(Username, Password).FirstOrDefault().Response;
            Session["Username"] = Username;

            switch (log)
            {
                case "Failed":
                    ViewBag.Warning = "نام کاربری یا کلمه ی عبور صحیح نیست";
                    if (Request.IsAjaxRequest())
                        return PartialView();
                    return View();
                    break;
            }
            return RedirectToAction("Index", "Admin");

        }

    }
}