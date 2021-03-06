﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seafood.Models;

namespace Seafood.Controllers
{
    public class HomeController : Controller
    {
        private SeafoodDbContext db = new SeafoodDbContext();
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }
        public IActionResult Delivery()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
