﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlantTrackerApp
{
    public class PlantTrackerContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;" +
                "Username=postgres;" +
                "Password=password123;" +
                "Database=PlantTracker")
                .UseSnakeCaseNamingConvention();
        }
    }
}
