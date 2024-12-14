using TokerChat.Api.Dto;
using TokerChat.Api.Mediators.Commands;

namespace TokerChat.Api.Interfaces
{
    public interface IContactService
    {
        Task<ContactDto> AddContactAsync(CreateContactCommandDto contactDto, CancellationToken cancellationToken);
        IAsyncEnumerable<ContactDto> GetContactsAsync();
    }
}
