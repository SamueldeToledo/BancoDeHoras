using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BancoDeHoras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolhaHoras : ControllerBase
    {
        private readonly IFolhaHorasUsuarioService _service;

        public FolhaHoras(IFolhaHorasUsuarioService service)
        {
            _service = service;
        }

        [HttpGet("Get all hours")]
        public ActionResult<IList<FolhaHorasUsuarioDTO>> GetAll()
        {
            try
            {
                return Ok(_service.GetAll());

            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
        }

        [HttpPost("Insert the point")]
        public void Post([Required][FromQuery] FolhaHorasUsuarioDTO entity)
        {
            _service.Post(entity);
            Ok("Ponto inserido com sucesso!!");
            return;
        }

        [HttpPut("Update the point")]
        public void Put(FolhaHorasUsuarioDTO entity)
        {
            _service.Put(entity);
            Ok("Ponto atualizado com sucesso!!");
            return;
        }


        [HttpDelete("Delete Point")]
        public void Delete(FolhaHorasUsuarioDTO entity)
        {
            _service.Delete(entity);
            Ok("Ponto deletado com sucesso!!");
            return;
        }
    }
}
