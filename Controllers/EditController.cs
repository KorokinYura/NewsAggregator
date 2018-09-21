using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.Models;
using NewsAggregator.Services.Interfaces;

namespace NewsAggregator.Controllers
{
    public class EditController : Controller
    {
        private readonly INewsAggregator _newsAggregator;

        public EditController(INewsAggregator newsAggregator)
        {
            _newsAggregator = newsAggregator;
        }

        [Authorize(Roles = "Admin")]
        public void RemoveANews(int id)
        {
            _newsAggregator.RemoveANews(id);
            //return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin, Moderator")]
        [HttpPost]
        public void RemoveComment(int commentId, int newsId)
        {
            _newsAggregator.RemoveComment(commentId);
            //return RedirectToAction("News", "Home", new { id = newsId });
        }

        public IActionResult EditNews(int id)
        {
            return View(_newsAggregator.GetEditNewsViewModel(id));
        }

        public IActionResult EditANews(News news, IFormFile image)
        {
            _newsAggregator.EditANews(news, image);
            return RedirectToAction("News", "Home", new { id = news.Id });
        }

        public IActionResult ConfirmANews(int id)
        {
            _newsAggregator.ConfirmANews(id);
            return RedirectToAction("Index", "Home");
        }
    }
}