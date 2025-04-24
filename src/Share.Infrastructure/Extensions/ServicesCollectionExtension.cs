using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Share.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Share.Application.Abstractions.UnitOfWork;
using Share.Infrastructure.Implements.UnitOfWork;
using Share.Infrastructure.Data.Seeders;
using Share.Application.Abstractions.Repository;
using Share.Infrastructure.Implements.Repository;

//Where we register DI services for the infrastructure layer
namespace Share.Infrastructure.Extensions
{
    public static class ServicesCollectionExtension
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Application DB Context Register
            var connectionString = configuration.GetConnectionString("Avatar2D");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            
            //Data Seeder
            services.AddScoped<IDataSeeder, DataSeeder>();

            //UnitOfWork & Repository
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Services
            // Configurations

            //Services DI


        }
    }
}
