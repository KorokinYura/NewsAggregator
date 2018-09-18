﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
            var i = _db.Users.First(u => u.UserName == comment.UserName).ImageHref;
            return new { id = comment.Id, comment.UserName, comment.Text, date = comment.Date.ToString("dd/MM/yyyy HH:mm:ss"), imagePath = _db.Users.First(u => u.UserName == comment.UserName).ImageHref };
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

        public void EditANews(News news)
        {
            News oldNews = _db.News.FirstOrDefault(n => n.Id == news.Id);
            if (oldNews != null)
            {
                oldNews.Name = news.Name;
                oldNews.Text = news.Text;
            }
            _db.SaveChanges();
        }

        public NewsViewModel GetNewsViewModel(int id)
        {
            var news = _db.News.First(n => n.Id == id);
            news.Views++;
            _db.SaveChanges();

            return new NewsViewModel()
            {
                News = news,
                Users = _db.Users,
                Comments = _db.Comments.Where(c => c.NewsId == id)
            };
        }

        public IndexViewModel GetIndexViewModel()
        {
            return new IndexViewModel()
            {
                News = _db.News
            };
        }

        public EditNewsViewModel GetEditNewsViewModel(int id)
        {
            return new EditNewsViewModel()
            {
                News = _db.News.First(n => n.Id == id)
            };
        }
    }
}
