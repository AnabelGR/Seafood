using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Seafood.Models;
using Microsoft.AspNetCore.Identity;

namespace Seafood.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly SeafoodDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager, SeafoodDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Subscribers()
        {
            return View(_db.Subscribers.ToList());
        }
    }
}