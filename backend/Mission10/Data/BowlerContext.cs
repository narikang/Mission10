﻿using Microsoft.EntityFrameworkCore;

namespace Mission10.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }

        public DbSet<Bowler> Bowlers { get; set; }

        public virtual DbSet<Team> Teams { get; set; }
    }
}
