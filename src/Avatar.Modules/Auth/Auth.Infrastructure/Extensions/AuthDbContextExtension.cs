using Avatar.Modules.Auth.Auth.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Share.Infrastructure.Data;
using Share.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Modules.Auth.Auth.Infrastructure.Extensions
{
    public class AuthModelConfiguration : IModelConfiguration
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountConfig).Assembly);
        }
    }
}
