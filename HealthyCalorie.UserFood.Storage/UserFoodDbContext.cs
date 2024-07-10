using HealthyCalorie.Common.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.Storage
{
    public class UserFoodDbContext : TechnicalTrainingContext
    {
        private IConfiguration _configuration { get; }

        public DbSet<Entities.UserFood> UserFoods { get; set; }
        public DbSet<Entities.UserFoodCategory> UserFoodCategories { get; set;}
        public DbSet<Entities.UserFoodNutrient> UserFoodNutrients { get; set; }
        public DbSet<Entities.UserNutrient> UserNutrients { get;set; }

        public UserFoodDbContext() { }

        public UserFoodDbContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UserFood.db", x => x.MigrationsHistoryTable("__EFMigrationsHistory", "UserFood"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.UserFood>()
               .HasMany(f => f.UserFoodsNutrients)
               .WithOne(fn => fn.UserFood)
               .HasForeignKey(fn => fn.FoodId);

            modelBuilder.Entity<Entities.UserNutrient>()
                .HasMany(n => n.UserFoodNutrients)
                .WithOne(fn => fn.Nutrient)
                .HasForeignKey(fn => fn.NutrientId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
