using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bART.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly BartContext _context;
        private readonly IContactService _contactService;
        public ContactsController(BartContext context, IContactService contactService)
        {
            _context = context;
            _contactService = contactService;
        }
        [HttpPost("createContact(StepByStep)")]
        public async Task<IActionResult> CreateAccount(ContactDTO account)
        {
            await _contactService.CreateContactAsync(account);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
