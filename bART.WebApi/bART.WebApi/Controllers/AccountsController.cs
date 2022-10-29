using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace bART.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly BartContext _context;
        private readonly IAccountService _accountService;

        public AccountsController(BartContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }
        [HttpPost("createAccount(Create Account with Contact)")]
        public async Task<IActionResult> CreateAccount(AccountDTO account)
        {
            await _accountService.CreateAccountAsync(account);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
