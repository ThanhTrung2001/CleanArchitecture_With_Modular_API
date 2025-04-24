using Avatar.Modules.Auth.Auth.Application.Abstractions.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Avatar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAccountService _accountService;
        public AuthController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // AccountService
        //GET ALL
        [HttpGet("Accounts")]
        public async Task<IActionResult> GetAllAccounts()
        {
            var result = await _accountService.GetAccountList();
            return Ok(result);
        }

    }
}
