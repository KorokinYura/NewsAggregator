using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.Models;
using NewsAggregator.Models.ViewModels;
using NewsAggregator.Services.Interfaces;

namespace NewsAggregator.Controllers
{
    public class LoadController : Controller
    {
        private readonly INewsAggregator _newsAggregator;

        public LoadController(INewsAggregator newsAggregator)
        {
            _newsAggregator = newsAggregator;
        }

        public IEnumerable<object> LoadMoreComments(int id, int curComments)
        {
            return _newsAggregator.LoadMoreComments(id, curComments);
        }
    }
}