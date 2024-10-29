using BancoDeHoras.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.Interfaces
{
    public interface IMarcaPontoService
    {
        IList<MarcaPontoDTO> GetAll();
        MarcaPontoDTO Get(int id);
        void Post(MarcaPontoDTO entity);
        void Put(MarcaPontoDTO entity);
        void Delete(MarcaPontoDTO entity);
    }
}
