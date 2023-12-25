
using System.ComponentModel.DataAnnotations;

namespace HistoricalTrails.HistoricalPlaces;

    public class CreateUpdateHistoricalPlaceDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string History { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }

