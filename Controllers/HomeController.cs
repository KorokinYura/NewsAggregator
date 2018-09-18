﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.Data;
using NewsAggregator.Models;
using NewsAggregator.Services.Interfaces;

namespace NewsAggregator.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsAggregator _newsAggregator;

        public HomeController(INewsAggregator newsAggregator)
        {
            _newsAggregator = newsAggregator;
        }

        public IActionResult Index()
        {
            return View(_newsAggregator.GetIndexViewModel());
        }

        public IActionResult News(int id)
        {
            return View(_newsAggregator.GetNewsViewModel(id));
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateNews()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateANewsAsync(News news, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                news.UserName = User.Identity.Name;
                news.Date = DateTime.Now;
                await _newsAggregator.AddANewsAsync(news, image);
            }
            else
            {
                return RedirectToAction("CreateNews");
            }

            return RedirectToAction("News", new { news.Id });
        }

        [Authorize]
        [HttpPost]
        public async Task<object> CreateCommentAsync(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.UserName = User.Identity.Name;
                comment.Date = DateTime.Now;
                await _newsAggregator.AddCommentAsync(comment);
            }

            return _newsAggregator.FormComment(comment);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult RemoveANews(int id)
        {
            _newsAggregator.RemoveANews(id);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin, Moderator")]
        [HttpPost]
        public IActionResult RemoveComment(int commentId, int newsId)
        {
            _newsAggregator.RemoveComment(commentId);
            return RedirectToAction("News", new { id = newsId });
        }
        
        public IActionResult EditNews(int id)
        {
            return View(_newsAggregator.GetEditNewsViewModel(id));
        }

        [HttpPost]
        public IActionResult EditANews(News news)
        {
            _newsAggregator.EditANews(news);
            return RedirectToAction("News", new { id = news.Id });
        }

        public IActionResult ConfirmANews(int id)
        {
            _newsAggregator.ConfirmANews(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
