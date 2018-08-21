using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(10000, MinimumLength = 1)]
        public string Text { get; set; }
        public string UserName { get; set; }
        public int Views { get; set; }
        public DateTime Date { get; set; }
        public string ImageHref { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
