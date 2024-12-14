using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TokerChat.Api.Dto;
using TokerChat.Api.Infraestructure.Persistence;
using TokerChat.Api.Interfaces;
using TokerChat.Api.Mediators.Commands;
using TokerChat.Api.Models;

namespace TokerChat.Api.Services
{
    public class ContactService : IContactService
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ContactService> _logger;
        public ContactService(ApplicationDbContext context, IMapper mapper, ILogger<ContactService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ContactDto> AddContactAsync(CreateContactCommandDto contactDto, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Contact>(contactDto);
            _context.Contacts.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Mensaje de bienvenida enviado a {Name} al número {PhoneNumber}",
                               entity.Name, entity.PhoneNumber);

            return _mapper.Map<ContactDto>(entity);
        }
    }


}
