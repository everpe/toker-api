using TokerChat.Api.Dto;
using TokerChat.Api.Models;
using AutoMapper;
using TokerChat.Api.Mediators.Commands;
namespace TokerChat.Api.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<CreateContactCommandDto, Contact>();
        }
    }
}
