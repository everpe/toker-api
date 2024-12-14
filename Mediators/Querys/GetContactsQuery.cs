using MediatR;
using TokerChat.Api.Dto;
using TokerChat.Api.Interfaces;

namespace TokerChat.Api.Mediators.Querys
{
    public class GetContactsQuery : IStreamRequest<ContactDto>
    {
   

        public class Handler : IStreamRequestHandler<GetContactsQuery, ContactDto>
        {
            private readonly IContactService _pacienteService;

            public Handler(IContactService pacienteService)
            {
                _pacienteService = pacienteService;
            }

            public IAsyncEnumerable<ContactDto> Handle(GetContactsQuery request, CancellationToken cancellationToken)
            {
                return _pacienteService.GetContactsAsync();
            }
        }

    }
}
