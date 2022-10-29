using bART.Data.Dto;
using FluentValidation;

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
