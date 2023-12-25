using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HistoricalTrails.Newscasts
{
    public class CreateUpdateNewscastDto
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
