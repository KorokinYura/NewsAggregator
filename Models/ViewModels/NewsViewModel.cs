using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Models.ViewModels
{
    public class NewsViewModel
    {
        public News News { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<AppUser> Users { get; set; }
    }
}
