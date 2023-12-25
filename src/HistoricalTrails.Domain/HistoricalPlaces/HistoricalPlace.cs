using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HistoricalTrails.HistoricalPlaces
{
    public class HistoricalPlace : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string ImageUrl { get; set; }
    }
}
