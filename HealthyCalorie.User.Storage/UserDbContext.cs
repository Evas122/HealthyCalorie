using HealthyCalorie.Common.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.User.Storage
{
    public class UserDbContext : TechnicalTrainingContext
    {
        private IConfiguration _configuration;

        public DbSet<Entities.User> Users { get; set; }
        public DbSet<Entities.Role> Roles { get; set; }
        public DbSet<Entities.UserRole> UsersRoles { get; set; }

        public UserDbContext() { }

        public UserDbContext(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=User.db", x => x.MigrationsHistoryTable("__EFMigrationsHistory", "User"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
