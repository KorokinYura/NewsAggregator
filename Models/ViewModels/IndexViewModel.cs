using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<News> News { get; set; }
    }
}
