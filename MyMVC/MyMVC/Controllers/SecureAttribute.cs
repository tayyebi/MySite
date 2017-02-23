using System;
using System.Web.Mvc;

namespace WebInterface.Controllers
{
    class SecureAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool CanAccess = false;
            try
            {
                if (filterContext.HttpContext.Session["Username"] != null)
                    CanAccess = true;
            }
            catch
            {
                CanAccess = false;
            }
            if (!CanAccess)
                filterContext.Result = new HttpStatusCodeResult(401);
        }
    }

}