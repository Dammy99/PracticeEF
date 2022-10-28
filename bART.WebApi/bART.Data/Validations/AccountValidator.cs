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
            //RuleFor(ac => ac.AccountName).NotEmpty().WithMessage("Empty Account Name");
            //RuleFor(ac => ac.IncidentName).NotEmpty().WithMessage("Empty Incident Name"); ;
            //RuleFor(incidentik => incidentik.IncidentName == )
        }
    }
    //public class NotFoundAccountValidator : ValidationAttribute
    //{
    //    private readonly IBartContext _context;
    //    public NotFoundAccountValidator(IBartContext service)
    //    {
    //        _context = service;
    //    }
    //    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    //    {
    //        var user = validationContext.ObjectInstance as Account;
    //        if (_context.Accounts.First(us => us.AccountName == user!.IncidentName) == null)
    //        {
    //            return new ValidationResult("Not found 404");
    //        }
    //        else
    //        {
    //            return ValidationResult.Success;
    //        }
    //    }
    //}
}
