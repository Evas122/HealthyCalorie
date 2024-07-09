using HealthyCalorie.Common.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Recipe.Storage
{
    public class RecipeDbContext : TechnicalTrainingContext
    {
        private IConfiguration _configuration;

        public DbSet<Entities.Recipe> Recipes { get; set; }
        public DbSet<Entities.RecipeIngredient> RecipeIngredients { get; set;}

        public RecipeDbContext() { }

        public RecipeDbContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Recipe.db", x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Recipe"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
