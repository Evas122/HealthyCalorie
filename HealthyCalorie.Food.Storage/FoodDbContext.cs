using HealthyCalorie.Common.Storage;
using HealthyCalorie.Food.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Food.Storage
{
    public class FoodDbContext : TechnicalTrainingContext
    {
        private IConfiguration _configuration { get; }
        

        public DbSet<Entities.Food> Foods { get; set; }
        public DbSet<Entities.FoodCategory> FoodCategories { get; set; }
        public DbSet<Entities.FoodNutrient> FoodNutrients { get;set; }
        public DbSet<Entities.Nutrient> Nutrients { get; set;}

        public FoodDbContext() { }

        public FoodDbContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Food.db", x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Food"));
            optionsBuilder.LogTo(x => System.Diagnostics.Debug.WriteLine(x));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Food>()
                .HasMany(f => f.FoodNutrients)
                .WithOne(fn => fn.Food)
                .HasForeignKey(fn => fn.FdcId);

            modelBuilder.Entity<Nutrient>()
                .HasMany(n => n.FoodNutrients)
                .WithOne(fn => fn.Nutrient)
                .HasForeignKey(fn => fn.NutrientId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
