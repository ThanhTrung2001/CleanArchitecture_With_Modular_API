using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{
        //}
        //If we use public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
        //We need to remove the constructor above and replace with public class ApplicationDbContext : DbContext

        // Define your DbSets (tables) here
        // public DbSet<YourEntity> YourEntities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // cấu hình Fluent API ở đây nếu cần
        }

    }
}
