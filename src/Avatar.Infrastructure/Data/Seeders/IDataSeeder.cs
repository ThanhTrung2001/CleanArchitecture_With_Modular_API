using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Infrastructure.Data.Seeders
{
    internal interface IDataSeeder
    {
        Task InitSeedDataAsync();
    }
}
