using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.Data;
using NewsAggregator.Models;
using NewsAggregator.Models.ViewModels;
using NewsAggregator.Services.Interfaces;

namespace NewsAggregator.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsAggregator _newsAggregator;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(INewsAggregator newsAggregator, UserManager<AppUser> userManager)
        {
            _newsAggregator = newsAggregator;
            _userManager = userManager;
        }

        public IActionResult Index(int newsCount = 0)
        {
            return View(_newsAggregator.GetIndexViewModel(newsCount));
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

        public IActionResult Search(string searchRequest)
        {
            searchRequest = searchRequest ?? "";
            return View("Index", _newsAggregator.GetSearchIndexViewModel(searchRequest));
        }

        public async Task AddModerAsync(string userName)
        {
            if(userName != null)
            {
                AppUser user = await _userManager.FindByNameAsync(userName);

                if (!User.IsInRole("Moderator"))
                {
                    await _userManager.AddToRoleAsync(user, "Moderator");
                }
            }
        }
        
        public async Task RemoveModerAsync(string userName)
        {
            AppUser user = await _userManager.FindByNameAsync(userName);

            if (!User.IsInRole("Moderator"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Moderator");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
