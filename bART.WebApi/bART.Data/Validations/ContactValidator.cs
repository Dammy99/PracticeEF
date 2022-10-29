using bART.Data.Dto;
using FluentValidation;

namespace bART.Data.Validations
{
    public class ContactValidator : AbstractValidator<ContactDTO>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
