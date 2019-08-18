using FirstMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


using System.Data.Entity;



namespace FirstMVCWebApp.Controllers
{
    public class ProductController : Controller
    {
        StoreContext db = new StoreContext();
       
        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<Product> products =   db.Products;

            ViewBag.Products = products;
            return View();
        }

        public async Task<ActionResult>  Details(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд футболиста
            Product p = await db.Products.FindAsync(id);
            if (p == null)
            {
                return HttpNotFound();
            }

            //ViewBag.Product = p;
            //return View(p);
            // Создаем список команд для передачи в представление
            SelectList cat = new SelectList(db.Categories, "Id", "Name", p.CategoryId);
            ViewBag.Categ = cat;
            return View(p);





            //Product p = await  db.Products.FindAsync(id);
            //if (p == null)
            //{
            //    return HttpNotFound();
            //}

            //ViewBag.Product = p;
            //ViewData["volume"] = p.Volume;
            //ViewData["volume1"] = p.Volume;


            //return View(p);
        }

        [HttpGet]
        public async Task<ActionResult> Delete(Product p)
        {
           // Product p = db.Products.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            Product p1 = await db.Products.FindAsync(p.Id);
            if (p1 == null)
            {
                return HttpNotFound();
            }

           // ViewBag.Product = p1;
            SelectList cat = new SelectList(db.Categories, "Id", "Name", p.CategoryId);
            ViewBag.Categ = cat;
            return View(p1);
        }

        [HttpPost]  
        public async Task<ActionResult> Delete(int  id)
        {
            Product p = await db.Products.FindAsync(id);
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
            SelectList categ = new SelectList(db.Categories, "Id", "Name");
            ViewBag.Categ = categ;
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Add(Product p)
        {
            db.Products.Add(p);
            await db.SaveChangesAsync();

            //return View();
            return RedirectToAction("Index");

        }

        //[HttpPost]
        //public ActionResult DeleteProduct()
        //{
        //    return View();
        //}

        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд футболиста
            Product p = await  db.Products.FindAsync(id);
            if (p == null)
            {
                return HttpNotFound();
            }

            //ViewBag.Product = p;
            //return View(p);
            // Создаем список команд для передачи в представление
            SelectList cat = new SelectList(db.Categories, "Id", "Name", p.CategoryId);
            ViewBag.Categ = cat;
            return View(p);
        }


        [HttpPost]
        public async Task<ActionResult> Edit(Product p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }





        // Выводим всех футболистов
         [HttpGet]
        public ActionResult AllProducts()
        {
            var players = db.Products.Include(p => p.Category);
            ViewBag.Product = players;
            return View(players.ToList());
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