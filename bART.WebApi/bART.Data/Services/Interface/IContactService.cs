using bART.Data.Dto;

namespace bART.Data.Services.Interface
{
    public interface IContactService
    {
        Task CreateContactAsync(ContactDTO account);
    }
}
