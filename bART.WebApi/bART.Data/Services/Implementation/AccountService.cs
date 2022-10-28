using bART.Data.Context;
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
        public AccountService(IBartContext context)
        {
            _context = context;
        }
        
    }
}
