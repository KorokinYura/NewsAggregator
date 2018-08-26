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

namespace NewsAggregator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _appEnvironment;

        public HomeController(ApplicationDbContext db, IHostingEnvironment appEnvironment)
        {
            _db = db;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View(_db.News);
        }

        public IActionResult News(int id)
        {
            return View(new Tuple<News, ApplicationDbContext>(_db.News.First(n => n.Id == id), _db));
            //return View(new Tuple<News, IEnumerable<Comment>>(_db.News.First(n => n.Id == id), _db.Comments));
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateNews()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateANews(string name, string text, IFormFile image)
        {
            News news = new News();

            if (ModelState.IsValid)
            {
                news.UserName = User.Identity.Name;
                news.Name = name;
                news.Text = text;
                news.Date = DateTime.Now;

                string path;
                if (image != null)
                {
                    path = "/images/NewsImages/" + image.FileName;

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

                _db.News.Add(news);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateComment(int newsId, string text)
        {
            Comment comment = new Comment();

            if (ModelState.IsValid)
            {
                comment.UserName = User.Identity.Name;
                comment.Text = text;
                comment.Date = DateTime.Now;
                comment.NewsId = newsId;
                _db.Comments.Add(comment);
                _db.SaveChanges();
            }

            //return comment;
            return RedirectToAction("News", new { id = newsId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
