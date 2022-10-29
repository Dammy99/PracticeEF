using bART.Data.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Validations
{
    public class AccountForIncidentValidator : AbstractValidator<AccountForIncidentDTO>
    {
        public AccountForIncidentValidator()
        {
            RuleFor(ac => ac.AccountName).NotEmpty();
        }
    }
}
