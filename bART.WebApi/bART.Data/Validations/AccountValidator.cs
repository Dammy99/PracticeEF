using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Validations
{
    public class AccountValidator : AbstractValidator<AccountDTO>
    {
        public AccountValidator()
        {

            RuleFor(ac => ac.AccountName).NotEmpty();
            RuleForEach(ac => ac.Contacts).SetValidator(new ContactValidator());

        }
    }
}
