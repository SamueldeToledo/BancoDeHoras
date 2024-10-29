using BancoDeHoras.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.Interfaces
{
    public interface IFolhaHorasUsuarioService
    {
        IList<FolhaHorasUsuarioDTO> GetAll();
        Task<FolhaHorasUsuarioDTO> Get(int id);
        void Post(FolhaHorasUsuarioDTO entity);
        void Put(FolhaHorasUsuarioDTO entity);
        void Delete(FolhaHorasUsuarioDTO entity);
    }
}
