using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seafood.Models;

namespace Seafood.Controllers
{
    public class SubscriberController : Controller
    {
        private SeafoodDbContext db = new SeafoodDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return RedirectToAction("Index", "HomeController");
        }
        [HttpPost]
        public IActionResult Create(Subscriber subscriber)
        {
            db.Subscribers.Add(subscriber);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisSubscriber = db.Subscribers.FirstOrDefault(subscribers => subscribers.SubscriberId == id);
            return View(thisSubscriber);
        }
        [HttpPost]
        public IActionResult Edit(Subscriber subscriber)
        {
            db.Entry(subscriber).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var thisSubscriber = db.Subscribers.FirstOrDefault(subscribers => subscribers.SubscriberId == id);
            return View(thisSubscriber);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisSubscriber = db.Subscribers.FirstOrDefault(subscribers => subscribers.SubscriberId == id);
            db.Subscribers.Remove(thisSubscriber);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
