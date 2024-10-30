using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BancoDeHoras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaPontoController : ControllerBase
    {
        private readonly IMarcaPontoService _service;

        public MarcaPontoController(IMarcaPontoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IList<MarcaPontoDTO>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public ActionResult Post(MarcaPontoDTO entity)
        {
            if (entity.Id == 0 || entity.Id == null)
                return BadRequest("Insira um ID para continuar a operação");

            _service.Post(entity);
            return Ok("Dados inseridos com sucesso!!!");
        }

        [HttpPut]
        public ActionResult Put([Required][FromQuery]MarcaPontoDTO entity)
        {
            if (entity.Id == 0 || entity.Id == null)
                return BadRequest("Insira um ID para continuar a operação");

            _service.Put(entity);
            return Ok("Dados atualizados com sucesso!!!");

        }

        [HttpDelete]
        public ActionResult Delete(MarcaPontoDTO entity)
        {
            if (entity.Id == 0 || entity.Id == null)
                return BadRequest("Insira um ID para continuar a operação");

            _service.Delete(entity);
            return Ok("Dado deletado com sucesso!!!");

        }
    }
}
