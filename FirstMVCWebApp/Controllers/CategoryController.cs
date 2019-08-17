using FirstMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace FirstMVCWebApp.Controllers
{
    public class CategoryController : Controller
    {
        StoreContext db = new StoreContext();
        // GET: Category
        public ActionResult Index()
        {
            IEnumerable<Category> categories = db.Categories;

            ViewBag.Categories = categories;
            return View();
        }


        public ActionResult CategoryDetails(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Category team = db.Categories.Include(t => t.Products).FirstOrDefault(t => t.Id == id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }
    }
}