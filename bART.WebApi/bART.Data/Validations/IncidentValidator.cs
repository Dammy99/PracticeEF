using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Validations
{
    public class IncidentValidator : AbstractValidator<IncidentDTO>
    {
        public IncidentValidator()
        {
            RuleForEach(incidentik => incidentik.Accounts).NotEmpty();
            RuleFor(inc => inc.Description).NotEmpty().NotNull().WithMessage("Enter Data");
            //RuleFor(incidentik => incidentik.IncidentName == )
            RuleForEach(incidentik => incidentik.Accounts).SetValidator(new AccountValidator());
        }
    }
}
