using BancoDeHoras.Application.DTO;
using BancoDeHoras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.Interfaces
{
    public interface IUsuarioService
    {
        IList<UsuarioDTO> GetAll(Expression<Func<UsuarioDTO, bool>> predicate = null);
        UsuarioDTO Get(Expression<Func<UsuarioDTO, bool>> predicate);
        void Post(UsuarioDTO entity);
        void Put(UsuarioDTO entity);
        void Delete(UsuarioDTO entity);
    }
}
