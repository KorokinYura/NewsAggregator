using Microsoft.AspNetCore.Http;
using NewsAggregator.Models;
using NewsAggregator.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Services.Interfaces
{
    public interface INewsAggregator
    {
        Task AddCommentAsync(Comment comment);
        Task AddANewsAsync(News news, IFormFile image); 
        Task UpdateDbAsync();
        void RemoveANews(int id);
        void ConfirmANews(int id);
        void RemoveComment(int id);
        void EditANews(News news, IFormFile image);
        object FormComment(Comment comment);
        Task<NewsViewModel> GetNewsViewModelAsync(int id, int commentsLoad = 0);
        IndexViewModel GetIndexViewModel(int newsCount);
        IndexViewModel GetSearchIndexViewModel(string searchRequest);
        EditNewsViewModel GetEditNewsViewModel(int id);
        IEnumerable<object> LoadMoreComments(int id, int curComments);
    }
}
