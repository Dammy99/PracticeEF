using bART.Data.Validations;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Dto
{
    public class AccountDTO
    {
        public string AccountName { get; set; } = null!;

        //public virtual ICollection<Contact>? Contacts { get; set; }
    }
}
