using AutoMapper;
using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Services.Implementation
{
    public class ContactService: IContactService
    {
        private readonly IBartContext _context;
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;

        public ContactService(IBartContext context, IMapper mapper, IAccountService accountService)
        {
            _context = context;
            _mapper = mapper;
            _accountService = accountService;
        }

        public async Task CreateContactAsync(ContactDTO contact)
        {
            var contactInfo = _mapper.Map<Contact>(contact);
            if(!await _context.Contacts.AnyAsync(x => x.Email == contactInfo.Email))
            {
                await _accountService.CreateAccountForContactAsync(contact);
                //await _context.Contacts.AddAsync(contactInfo);
            }
            else
            {
                var oldContact = _context.Contacts.Find(contactInfo.Email);
                oldContact.FirstName = contactInfo.FirstName;
                oldContact.LastName = contactInfo.LastName;
                if (oldContact.AccountName == null)
                {
                    _context.Contacts.Remove(oldContact);
                    await _accountService.CreateAccountForContactAsync(contact);
                }
                else
                {
                    _context.Entry(oldContact!).State = EntityState.Modified;
                }

            }
        }
    }
}
