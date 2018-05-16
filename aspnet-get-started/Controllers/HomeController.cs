using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ServerName = Server.MachineName;
            ViewBag.RemoteAddress = Request.ServerVariables["REMOTE_ADDR"];
            ViewBag.XforwardedFor = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}