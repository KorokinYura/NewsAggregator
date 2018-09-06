using Microsoft.AspNetCore.Http;
using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Services.Interfaces
{
    public interface INewsAggregator
    {
        Task AddCommentAsync(Comment comment);
        Task AddANewsAsync(News news);
        Task UpdateDbAsync();
        void RemoveANews(int id);
        void RemoveComment(int id);
        void EditANews(News news);
        object FormComment(Comment comment);
        IQueryable<Comment> GetComments();
        IQueryable<News> GetNews();
        IQueryable<AppUser> GetUsers();
        News GetNewsById(int id);
    }
}
