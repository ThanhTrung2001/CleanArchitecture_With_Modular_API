using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Modules.ExampleModule
{
    public static class ExampleModuleRegistration
    {
        public static IServiceCollection AddExampleModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Đăng ký DbContext
           

            // Đăng ký Repositories
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();

            // Đăng ký Application Services
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IProductService, ProductService>();

            // Đăng ký MediatR
            //services.AddMediatR(cfg => {
            //    cfg.RegisterServicesFromAssembly(typeof(ModuleRegistration).Assembly);
            //});

            // Đăng ký AutoMapper
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Đăng ký FluentValidation
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            // Đăng ký các background jobs
            //services.AddScoped<IBackgroundJobService, BackgroundJobService>();

            // Trả về IServiceCollection để có thể tiếp tục đăng ký các dịch vụ khác
            return services;
        }
    }
}
