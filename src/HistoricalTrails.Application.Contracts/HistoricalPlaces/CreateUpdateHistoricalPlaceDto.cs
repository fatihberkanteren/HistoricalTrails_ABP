﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricalTrails.HistoricalPlaces
{
    public class CreateUpdateHistoricalPlaceDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string ImageUrl { get; set; }
    }
}
