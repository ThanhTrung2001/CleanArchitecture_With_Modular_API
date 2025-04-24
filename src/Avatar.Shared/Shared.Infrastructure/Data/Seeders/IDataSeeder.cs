using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Shared.Shared.Infrastructure.Data.Seeders
{
    internal interface IDataSeeder
    {
        Task InitSeedDataAsync();
    }
}
