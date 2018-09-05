using Microsoft.AspNetCore.Http;
using NewsAggregator.Data;
using NewsAggregator.Models;
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

        public NewsAggregator(ApplicationDbContext db)
        {
            _db = db;
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

        public async Task AddANewsAsync(News news)
        {
            await _db.News.AddAsync(news);
            await _db.SaveChangesAsync();
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

        public IQueryable<Comment> GetComments()
        {
            return _db.Comments;
        }

        public IQueryable<News> GetNews()
        {
            return _db.News;
        }

        public IQueryable<AppUser> GetUsers()
        {
            return _db.AppUsers;
        }

        public News GetNewsById(int id)
        {
            return _db.News.First(n => n.Id == id);
        }

        public void RemoveANews(int id)
        {
            var news = _db.News.First(n => n.Id == id);
            _db.News.Remove(news);
            _db.SaveChanges();
        }

        public void RemoveComment(int id)
        {
            var comment = _db.Comments.First(c => c.Id == id);
            _db.Comments.Remove(comment);
            _db.SaveChanges();
        }
    }
}
