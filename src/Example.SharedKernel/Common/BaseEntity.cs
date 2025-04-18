using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.SharedKernel.Common
{
    public class BaseEntity
    {
        //[Key]
        public Guid ID { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
