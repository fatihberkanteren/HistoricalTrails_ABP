using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HistoricalTrails.Events
{
    public class CreateUpdateEventDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
