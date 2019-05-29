using Microsoft.EntityFrameworkCore;
using mike.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace mike.data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Section> Sections { get; set; }
    }
}
