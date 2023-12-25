using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace HistoricalTrails.Blogs
{
    public class BlogDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }
        public string AuthorName { get; set; }
    }
}
