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
    public class IncidentValidator : AbstractValidator<Incident>
    {
        //public IncidentValidator(IIncidentService service)
        //{
        //    RuleFor(incidentik => incidentik.Accounts).NotEmpty();
        //}
    }
}
