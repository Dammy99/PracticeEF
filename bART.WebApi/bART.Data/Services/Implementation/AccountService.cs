using AutoMapper;
using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Services.Implementation
{
    public class AccountService: IAccountService
    {
        private readonly IBartContext _context;
        private readonly IMapper _mapper;
        public AccountService(IBartContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAccountAsync(AccountDTO account)
        {
            var accountInfo = _mapper.Map<Account>(account);
            await _context.Accounts.AddAsync(accountInfo);
        }
        public async Task CreateAccountForContactAsync(ContactDTO contact)
        {
            AccountDTO newAccountDTO = new AccountDTO { 
                AccountName = $"{contact.Email}".Remove(contact.Email.Length - 10), 
                Contacts = new []{contact}};
            var accountInfo = _mapper.Map<Account>(newAccountDTO);
            await _context.Accounts.AddAsync(accountInfo);
        }
    }
}
