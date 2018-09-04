using System;
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
        private readonly IHostingEnvironment _appEnvironment;

        public HomeController(INewsAggregator newsAggregator, IHostingEnvironment appEnvironment)
        {
            _newsAggregator = newsAggregator;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View(_newsAggregator.GetNews());
        }

        public IActionResult News(int id)
        {
            return View(new Tuple<News, IEnumerable<Comment>, IEnumerable<AppUser>>(_newsAggregator.GetNewsById(id), _newsAggregator.GetComments(), _newsAggregator.GetUsers()));
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
                await _newsAggregator.AddANewsAsync(news);

                string path;
                if (image != null)
                {
                    path = "/images/NewsImages/" + news.Id + image.FileName.Substring(image.FileName.LastIndexOf('.'));

                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await image.CopyToAsync(fileStream);
                    }
                }
                else
                {
                    path = "/images/NewsImages/DefaultNews.png";
                }

                news.ImageHref = path;
                await _newsAggregator.UpdateDbAsync();
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
        [HttpPost]
        public IActionResult RemoveANews(int id)
        {
            _newsAggregator.RemoveANews(id);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult RemoveComment(int commentId, int newsId)
        {
            _newsAggregator.RemoveComment(commentId);
            return RedirectToAction("News", new { id = newsId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
