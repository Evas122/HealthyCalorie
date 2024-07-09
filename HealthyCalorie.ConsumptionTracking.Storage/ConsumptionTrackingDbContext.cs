using HealthyCalorie.Common.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.ConsumptionTracking.Storage
{
    public class ConsumptionTrackingDbContext : TechnicalTrainingContext
    {
        private IConfiguration _configuration;

        public DbSet<Entities.Consumption> Consumptions { get; set; }

        public ConsumptionTrackingDbContext() { }

        public ConsumptionTrackingDbContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ConsumptionTracking.db", x => x.MigrationsHistoryTable("__EFMigrationsHistory", "ConsumptionTracking"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
