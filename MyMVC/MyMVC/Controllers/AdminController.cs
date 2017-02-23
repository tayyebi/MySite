using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebInterface.Controllers;

namespace MyMVC.Controllers
{
    [Secure]
    public class AdminController : Controller
    {
        DcDataContext dc = new DcDataContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Password()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Password(string Password, string Confirm)
        {
            if (Password != Confirm)
                ViewBag.Warning = "کلمه ی عبور و تکرار آن همخوانی ندارد";

            return View();
        }
    }
}