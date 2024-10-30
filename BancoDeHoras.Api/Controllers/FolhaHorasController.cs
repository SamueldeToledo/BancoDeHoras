using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BancoDeHoras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolhaHorasController : ControllerBase
    {
        private readonly IFolhaHorasUsuarioService _service;

        public FolhaHorasController(IFolhaHorasUsuarioService service)
        {
            _service = service;
        }

        [Authorize]
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
        public void Post(FolhaHorasUsuarioDTO entity)
        {
            _service.Post(entity);
            Ok("Ponto inserido com sucesso!!");
            return;
        }

        [HttpPut("Update the point")]
        public ActionResult Put([Required][FromQuery] FolhaHorasUsuarioDTO entity)
        {
            if (entity.Id == null || entity.Id == 0)
                return BadRequest("Insira o ID para atualizar!!");

            _service.Put(entity);
            return Ok("Ponto atualizado com sucesso!!");

        }


        [HttpDelete("Delete Point")]
        public ActionResult Delete(FolhaHorasUsuarioDTO entity)
        {
            if (entity.Id == null || entity.Id == 0)
                return BadRequest("Insira o ID para deletar!!");


            _service.Delete(entity);
            return Ok("Ponto deletado com sucesso!!");
        }
    }
}
