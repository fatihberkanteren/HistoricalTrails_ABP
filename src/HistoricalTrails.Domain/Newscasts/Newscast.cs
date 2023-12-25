using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace HistoricalTrails.Newscasts
{
    public class Newscast : AuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }
    }
}
