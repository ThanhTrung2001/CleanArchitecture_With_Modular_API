using Microsoft.EntityFrameworkCore;
using Share.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{
        //}
        //If we use public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
        //We need to remove the constructor above and replace with public class ApplicationDbContext : DbContext

        // Define your DbSets (tables) here
        // public DbSet<YourEntity> YourEntities { get; set; }
        private readonly IEnumerable<IModelConfiguration> _moduleModelConfigs;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IEnumerable<IModelConfiguration> moduleModelConfigs)
            : base(options)
        {
            _moduleModelConfigs = moduleModelConfigs;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            foreach (var config in _moduleModelConfigs)
            {
                config.Configure(modelBuilder);
            }
        }
    }
}
