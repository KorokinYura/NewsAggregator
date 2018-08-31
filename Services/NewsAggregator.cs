using NewsAggregator.Data;
using NewsAggregator.Models;
using NewsAggregator.Services.Interfaces;
using System;
using System.Collections.Generic;
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

        public object FormComment(Comment comment)
        {
            var i = _db.Users.First(u => u.UserName == comment.UserName).ImageHref;
            return new { comment.UserName, comment.Text, date = comment.Date.ToString("dd/MM/yyyy hh:MM:ss"), imagePath = _db.Users.First(u => u.UserName == comment.UserName).ImageHref };
        }

        public IQueryable<Comment> GetCommentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
