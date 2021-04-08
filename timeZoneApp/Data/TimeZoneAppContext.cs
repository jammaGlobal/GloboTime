using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timeZoneApp.Models;

namespace timeZoneApp.Data
{
    public class TimeZoneAppContext : DbContext

    {
        public TimeZoneAppContext(DbContextOptions<TimeZoneAppContext> options) : base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=Test;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Region");
        }
    }
}
