using bART.Data.Dto;
using FluentValidation;

namespace bART.Data.Validations
{
    public class IncidentValidator : AbstractValidator<IncidentDTO>
    {
        public IncidentValidator()
        {
            RuleForEach(incidentik => incidentik.Accounts).NotEmpty();
            RuleFor(inc => inc.Description).NotEmpty().NotNull().WithMessage("Enter Data");
            RuleForEach(incidentik => incidentik.Accounts).SetValidator(new AccountForIncidentValidator());
        }
    }
}
