using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.Common
{
    public class BaseEntity
    {
        //[Key]
        public Guid ID { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
