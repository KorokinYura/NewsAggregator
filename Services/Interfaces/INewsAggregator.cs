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
        IQueryable<Comment> GetCommentsAsync();
        object FormComment(Comment comment);
    }
}
