using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Domain.Common
{
    internal class BaseEntity
    {
        //[Key]
         public Guid ID { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    
    }
}
