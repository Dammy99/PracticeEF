using bART.Data.Dto;
using FluentValidation;

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
