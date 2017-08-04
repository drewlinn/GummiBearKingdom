using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;
using System;

namespace GummiBearKingdom.Controllers
{
    public class HomeController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(db.Products);
        }

        public IActionResult Details(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(pro => pro.id == id);
            return View(thisProduct);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("List");

        }
        public IActionResult Delete(int id)
        {
            var thisPro = db.Products.FirstOrDefault(pro => pro.id == id);
            return View(thisPro);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisPro = db.Products.FirstOrDefault(pro => pro.id == id);
            db.Products.Remove(thisPro);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            var thisPro = db.Products.FirstOrDefault(pro => pro.id == id);
            return View(thisPro);
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
