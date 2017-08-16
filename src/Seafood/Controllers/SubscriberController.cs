using Microsoft.AspNetCore.Mvc;
using Seafood.Models;
using Microsoft.AspNetCore.Identity;

namespace Seafood.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly SeafoodDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public SubscriberController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SeafoodDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return RedirectToAction("Index", "Subscriber");
        }

        //public IActionResult Edit(int id)
        //{
        //    var thisSubscriber = db.Subscribers.FirstOrDefault(subscribers => subscribers.SubscriberId == id);
        //    return View(thisSubscriber);
        //}
        //[HttpPost]
        //public IActionResult Edit(Subscriber subscriber)
        //{
        //    db.Entry(subscriber).State = EntityState.Modified;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public ActionResult Delete(int id)
        //{
        //    var thisSubscriber = db.Subscribers.FirstOrDefault(subscribers => subscribers.SubscriberId == id);
        //    return View(thisSubscriber);
        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var thisSubscriber = db.Subscribers.FirstOrDefault(subscribers => subscribers.SubscriberId == id);
        //    db.Subscribers.Remove(thisSubscriber);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
