using FirstMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;


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



        [HttpGet]
        public ActionResult Create()
        {          
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Category c)
        {
            db.Categories.Add(c);
            await db.SaveChangesAsync();

            //return View();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд футболиста
            Category p = await db.Categories.FindAsync(id);
            if (p == null)
            {
                return HttpNotFound();
            }
                    
            return View(p);
        }


        [HttpPost]
        public async Task<ActionResult> Edit(Category p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд футболиста
            Category p = await db.Categories.FindAsync(id);
            if (p == null)
            {
                return HttpNotFound();
            }

            return View(p);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(Category p)
        {
            Category product = await db.Categories.FindAsync(p.Id);
            if (product == null)
                return HttpNotFound();

           // db.Database.ExecuteSqlCommand("ALTER TABLE dbo.Products ADD CONSTRAINT Players_Category FOREIGN KEY (CategoryId) REFERENCES dbo.[Categories] (Id) ON DELETE SET NULL");


            db.Categories.Remove(product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}