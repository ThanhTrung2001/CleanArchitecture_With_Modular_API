using Avatar.Modules.Auth.Auth.Domain.Enums;
using Share.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Modules.Auth.Auth.Domain.Entities
{
    public class Account : BaseEntity
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "Không đúng định dạng email"), MinLength(10, ErrorMessage = "Email không phù hợp.")]
        public string Email { get; set; }

        [Phone, MinLength(11)]
        public string PhoneNumber { get; set; }

        public EAccountRole Role { get; set; } = EAccountRole.User;

        public bool IsVerified { get; set; } = false;
    }
}
