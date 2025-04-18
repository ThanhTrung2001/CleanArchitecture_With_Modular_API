using Example.SharedKernel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Modules.ExampleModule.ExampleModule.Domain.Entities
{
    public class TodoItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
    }
}
