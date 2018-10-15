using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewsAggregator.Data;
using NewsAggregator.Models;
using NewsAggregator.Models.ViewModels;
using NewsAggregator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Services
{
    public class NewsAggregator : INewsAggregator
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _appEnvironment;
        private const int commentsLoad = 3;                     // number of comments loaded per click
        private const int newsLoad = 5;                         // number of news loaded per click

        public NewsAggregator(ApplicationDbContext db, IHostingEnvironment appEnvironment)
        {
            _db = db;
            _appEnvironment = appEnvironment;
        }

        public async Task AddCommentAsync(Comment comment)
        {
            await _db.Comments.AddAsync(comment);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task AddANewsAsync(News news, IFormFile image)
        {
            await _db.News.AddAsync(news);
            await UpdateDbAsync();

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
                path = "/images/DefaultImages/DefaultNews.png";
            }

            news.ImageHref = path;

            await UpdateDbAsync();
        }

        public async Task UpdateDbAsync()
        {
            await _db.SaveChangesAsync();
        }

        public object FormComment(Comment comment)
        {
            var user = _db.AppUsers.First(u => u.UserName == comment.UserName);

            return new
            {
                id = comment.Id,
                comment.UserName,
                comment.Text,
                date = comment.Date.ToString("dd/MM/yyyy HH:mm:ss"),
                imagePath = _db.AppUsers.FirstOrDefault(u => u.UserName == comment.UserName)?.ImageHref ?? "/images/DefaultImages/DefaultUser.png"
            };
        }

        public void RemoveANews(int id)
        {
            var news = _db.News.First(n => n.Id == id);
            if(news.ImageHref != null && news.ImageHref != "/images/DefaultImages/DefaultNews.png")
                File.Delete(_appEnvironment.WebRootPath + news.ImageHref);
            _db.News.Remove(news);
            _db.SaveChanges();
        }

        public void ConfirmANews(int id)
        {
            _db.News.First(n => n.Id == id).IsConfirmed = true;
            _db.SaveChanges();
        }

        public void RemoveComment(int id)
        {
            var comment = _db.Comments.First(c => c.Id == id);
            _db.Comments.Remove(comment);
            _db.SaveChanges();
        }

        public void EditANews(News news, IFormFile image)
        {
            News oldNews = _db.News.FirstOrDefault(n => n.Id == news.Id);
            if (oldNews != null)
            {
                oldNews.Name = news.Name;
                oldNews.Text = news.Text;

                string path;
                if (image != null)
                {
                    path = "/images/NewsImages/" + news.Id + image.FileName.Substring(image.FileName.LastIndexOf('.'));

                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }

                    if (oldNews.ImageHref != null && oldNews.ImageHref != "/images/DefaultImages/DefaultNews.png" && path != oldNews.ImageHref)
                        File.Delete(_appEnvironment.WebRootPath + oldNews.ImageHref);

                    oldNews.ImageHref = path;
                }
            }

            _db.SaveChanges();
        }

        public async Task<NewsViewModel> GetNewsViewModelAsync(int id, int curComments = 0)
        {
            var news = _db.News.First(n => n.Id == id);
            news.Views++;
            await _db.SaveChangesAsync();

            return new NewsViewModel()
            {
                News = news,
                Users = _db.Users,
                Comments = _db.Comments.Where(c => c.NewsId == id).AsEnumerable().Reverse().Take(curComments + commentsLoad)
            };
        }

        public IndexViewModel GetIndexViewModel(int newsCount)
        {
            return new IndexViewModel()
            {
                News = _db.News.OrderBy(n => !n.IsConfirmed).Take(newsCount + 5)
            };
        }

        public IndexViewModel GetSearchIndexViewModel(string searchRequest)
        {
            return new IndexViewModel
            {
                News = _db.News.Where(n => n.Name.Contains(searchRequest))
            };
        }

        public EditNewsViewModel GetEditNewsViewModel(int id)
        {
            return new EditNewsViewModel()
            {
                News = _db.News.First(n => n.Id == id)
            };
        }

        public IEnumerable<object> LoadMoreComments(int id, int curComments)
        {
            var comments = _db.Comments.Where(c => c.NewsId == id).AsEnumerable().Reverse().Skip(curComments).Take(commentsLoad);
            var retList = new List<object>();

            foreach(var comment in comments)
            {
                retList.Add(FormComment(comment));
            }

            return retList;
        }
    }
}
