﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantTrackerApp
{
    public class Plant
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Room Room { get; set; }
    }
}
