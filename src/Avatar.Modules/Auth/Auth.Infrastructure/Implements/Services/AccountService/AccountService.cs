using Avatar.Modules.Auth.Auth.Application.Abstractions.Services;
using Avatar.Modules.Auth.Auth.Domain.Entities;
using Share.Application.Abstractions.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Modules.Auth.Auth.Infrastructure.Implements.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Account>> GetAccountList()
        {
            try
            {
                return await _unitOfWork.Repository<Account>().GetAllAsync();
            }
            catch(Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
