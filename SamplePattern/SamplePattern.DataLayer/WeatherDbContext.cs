using Microsoft.EntityFrameworkCore;
using SamplePattern.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SamplePattern.DataLayer
{
    public class WeatherDbContext: DbContext
    {
        public DbSet<WeatherForeCast> WeatherForecasts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Weather.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<WeatherForeCast>().ToTable("Weather");
            modelBuilder.Entity<WeatherForeCast>(entity =>
            {
                entity.HasKey(e => e.Key);
                entity.Property(e => e.Date).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
