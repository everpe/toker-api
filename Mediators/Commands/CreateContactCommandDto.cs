using FluentValidation;
using MediatR;
using TokerChat.Api.Dto;
using TokerChat.Api.Interfaces;

namespace TokerChat.Api.Mediators.Commands
{
    public class CreateContactCommandDto : IRequest<ContactDto>
    {
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }

    public class CreateContactValidator : AbstractValidator<CreateContactCommandDto>
    {
        public CreateContactValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("El nombre es requerido.")
                .MaximumLength(255)
                .WithMessage("Máximo 255 caracteres permitidos."); ;

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .WithMessage("Número de telefono es requerido.")
                .MaximumLength(10)
                .WithMessage("Máximo 10 caracteres permitidos.");
        }


    }

    public class CreateContactHandler : IRequestHandler<CreateContactCommandDto, ContactDto>
    {
        private readonly IContactService _contactService;

        public CreateContactHandler(IContactService service)
        {
            _contactService = service;
        }

        public async Task<ContactDto> Handle(CreateContactCommandDto request, CancellationToken cancellationToken)
        {
            return await _contactService.AddContactAsync(request, cancellationToken);
        }

    }
}
