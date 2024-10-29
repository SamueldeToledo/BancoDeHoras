using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeHoras.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaPonto : ControllerBase
    {
        private readonly IMarcaPontoService _service;

        public MarcaPonto(IMarcaPontoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IList<MarcaPontoDTO>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public void Post(MarcaPontoDTO entity)
        {
            _service.Post(entity);
        }

        [HttpPut]
        public void Put(MarcaPontoDTO entity)
        {
            _service.Put(entity);
        }

        [HttpDelete]
        public void Delete(MarcaPontoDTO entity)
        {
            _service.Delete(entity);
        }
    }
}
