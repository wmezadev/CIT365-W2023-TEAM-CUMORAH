﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public class SacramentMeetingPlannerContext : DbContext
    {
        public SacramentMeetingPlannerContext (DbContextOptions<SacramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlanner.Models.Planner> Planner { get; set; } = default!;
        public DbSet<SacramentMeetingPlanner.Models.SpeachTopic> SpeachTopic { get; set; }
        public DbSet<SacramentMeetingPlanner.Models.Speaker> Speaker { get; set; }
        public DbSet<SacramentMeetingPlanner.Models.Speach> Speach { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
