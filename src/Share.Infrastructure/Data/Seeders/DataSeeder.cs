using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Infrastructure.Data.Seeders
{
    internal class DataSeeder : IDataSeeder
    {
        public async Task InitSeedDataAsync()
        {
            // Seed data logic goes here
            // For example, you can create default users, roles, etc.
            await Task.CompletedTask;
        }
    }
}
