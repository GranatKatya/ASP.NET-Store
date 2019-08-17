using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            // return View();
            return View("~/Views/Home/About.cshtml");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("About");
        }

        public ContentResult GetContent()
        {
            return Content("Hello");
        }

        public string GetString()
        {
            return "fdhgkdjfhgk";
        }
        public ActionResult StatusCode()
        {
            return new HttpStatusCodeResult(404);
        }
        public ActionResult Info()
        {
            return View();
        }
    }


}