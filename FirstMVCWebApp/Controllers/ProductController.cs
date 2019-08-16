using FirstMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCWebApp.Controllers
{
    public class ProductController : Controller
    {
        StoreContext db = new StoreContext();
       
        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<Product> products = db.Products;

            ViewBag.Products = products;
            return View();
        }

        public ActionResult Details(int id)
        {
             Product p = db.Products.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }

            ViewBag.Product = p;
            ViewData["volume"] = p.Volume;
            ViewData["volume1"] = p.Volume;


            return View(p);
        }

        [HttpGet]
        public ActionResult Delete(Product p)
        {
           // Product p = db.Products.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            Product p1 = db.Products.Find(p.Id);
            if (p1 == null)
            {
                return HttpNotFound();
            }

            ViewBag.Product = p1;
            return View();
        }

        [HttpPost]  
        public ActionResult Delete(int  id)
        {
            Product p = db.Products.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }

            db.Products.Remove(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();

            //return View();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteProduct()
        {
            return View();
        }


    //    [HttpPost]
        //public ActionResult DeleteProduct(int id)
        //{
        //    db.Products.Remove((from b in db.Products where b.Id == id select b).FirstOrDefault() );
        //    db.SaveChanges();

        //    //return View();
        //    return RedirectToAction("Index");
        //}
    }
}