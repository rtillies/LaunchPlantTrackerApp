﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantTrackerApp
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasSunlight { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();
    }
}
