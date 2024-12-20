﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TokerChat.Api.Dto;
using TokerChat.Api.Mediators.Commands;
using TokerChat.Api.Mediators.Querys;

namespace TokerChat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Permite registrar un nuevo contacto de usuario.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ContactDto>> CreateContact([FromBody] CreateContactCommandDto command)
        {
            var contactDto = await _mediator.Send(command);
            return Ok(new { Message = "Datos recibidos correctamente", Data = contactDto });
        }

        /// <summary>
        /// Permite consultar todos los contactos realizados.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IAsyncEnumerable<ContactDto> GetContacts()
        {
            return _mediator.CreateStream(new GetContactsQuery());
        }
    }
}
