using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using BancoDeHoras.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeHoras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Authentication : ControllerBase
    {
        private readonly IUsuarioService _service;

        public Authentication(IUsuarioService service)
        {
            _service = service;
        }
        [HttpPost]
        public void Post(UsuarioDTO entity)
        {
            _service.Post(entity);
        }
    }
}
