using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Infrastructure.Data.Configurations
{
    public interface IModelConfiguration
    {
        void Configure(ModelBuilder modelBuilder);
    }
}
