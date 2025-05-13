using Avatar.Modules.Auth.Auth.Application.Abstractions.Services;
using Avatar.Modules.Auth.Auth.Infrastructure.Extensions;
using Avatar.Modules.Auth.Auth.Infrastructure.Implements.Services.AccountService;
using Microsoft.Extensions.DependencyInjection;
using Share.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//register 
namespace Avatar.Modules.Auth
{
    public static class AuthModuleRegistration
    {
        public static void AddAuthModuleServices(this IServiceCollection services)
        {
            services.AddScoped<IModelConfiguration, AuthModelConfiguration>();
            services.AddScoped<IAccountService, AccountService>();
            
        }
    }
}
