using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seafood.Models;
using Microsoft.AspNetCore.Identity;

namespace Seafood.Controllers
{
    public class ItemController : Controller
    {
        private SeafoodDbContext db = new SeafoodDbContext();

        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }

        public IActionResult Detail(int id)
        {
            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
            return View(thisItem);
        }

        //    public IActionResult Create()
        //    {
        //        return View();
        //    }
        //    [HttpPost]
        //    public IActionResult Create(Item item)
        //    {
        //        db.Items.Add(item);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    public IActionResult Edit(int id)
        //    {
        //        var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
        //        return View(thisItem);
        //    }
        //    [HttpPost]
        //    public IActionResult Edit(Item item)
        //    {
        //        db.Entry(item).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    public ActionResult Delete(int id)
        //    {
        //        var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
        //        return View(thisItem);
        //    }

        //    [HttpPost, ActionName("Delete")]
        //    public IActionResult DeleteConfirmed(int id)
        //    {
        //        var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
        //        db.Items.Remove(thisItem);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
    }
}
