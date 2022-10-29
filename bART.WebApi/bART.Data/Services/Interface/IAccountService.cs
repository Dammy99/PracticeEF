using bART.Data.Dto;

namespace bART.Data.Services.Interface
{
    public interface IAccountService
    {
        Task CreateAccountAsync(AccountDTO incident);
        Task CreateAccountForContactAsync(ContactDTO contact);
    }
}
