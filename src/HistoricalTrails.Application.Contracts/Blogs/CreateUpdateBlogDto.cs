
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HistoricalTrails.Blogs
{
    public class CreateUpdateBlogDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
