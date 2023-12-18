using System;
using Volo.Abp.Application.Dtos;

namespace HistoricalTrails.HistoricalPlaces
{
    public class HistoricalPlaceDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string ImageUrl { get; set; }
    }
}
