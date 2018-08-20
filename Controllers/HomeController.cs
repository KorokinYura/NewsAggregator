﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.Data;
using NewsAggregator.Models;

namespace NewsAggregator.Controllers
{
    public class HomeController : Controller
    {
        readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.News);
        }

        public IActionResult News(int id)
        {
            return View(_db.News.First(n => n.Id == id));
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateNews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateANews(string name, string text)
        {
            News news = new News();

            if (ModelState.IsValid)
            {
                news.UserName = User.Identity.Name;
                news.Name = name;
                news.Text = text;
                news.Date = DateTime.Now;
                _db.News.Add(news);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
