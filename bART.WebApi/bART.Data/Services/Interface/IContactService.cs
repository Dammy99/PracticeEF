using bART.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Services.Interface
{
    public interface IContactService
    {
        Task CreateContactAsync(ContactDTO account);
    }
}
