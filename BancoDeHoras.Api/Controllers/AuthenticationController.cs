using AutoMapper;
using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using BancoDeHoras.CrossCutting.Interface;
using BancoDeHoras.CrossCutting.Jwt;
using BancoDeHoras.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace BancoDeHoras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUsuarioService _service;
        private readonly ITokenService _token;
        private readonly IMapper _mapper;

        public AuthenticationController(IUsuarioService service, ITokenService token, IMapper mapper)
        {
            _service = service;
            _token = token;
            _mapper = mapper;
        }

        [Authorize]
        [HttpPost]
        public ActionResult Post(UsuarioDTO entity)
        {
            if (entity.Nome == null || entity.Senha == null || entity.Nome == string.Empty || entity.Senha == string.Empty)
                return BadRequest("Preencha os campos corretamente!!!");

            _service.Post(entity);

            return Ok();
        }

        [HttpGet("Get user")]
        public ActionResult<UsuarioToken> Get([Required][FromQuery]UsuarioDTO entity)
        {
            var DTO = _mapper.Map<Usuario>(entity);
            var token = _token.GenerateToken(DTO);

            return token.Nome !="" ? Ok(token) : BadRequest("Nome ou senha incorretos");
        }

        [Authorize]
        [HttpDelete("Delete a user")]
        public ActionResult Delete([Required][FromQuery] Usuario entity)
        {
            _service.Delete(entity);
            return Ok();
        }

        [Authorize]
        [HttpPut]
        public ActionResult Put(UsuarioDTO entity)
        {
            if (entity.Id == null || entity.Id == 0)
                return BadRequest("É necessario ser informado o id do usuario!!!");
           
            _service.Put(entity);
            return Ok();
        }
    }
}
