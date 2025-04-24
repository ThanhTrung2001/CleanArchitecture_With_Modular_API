using Avatar.Modules.Auth.Auth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Modules.Auth.Auth.Application.Services.AccountService
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccountList();
    }
}
