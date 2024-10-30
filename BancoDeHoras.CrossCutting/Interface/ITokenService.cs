using BancoDeHoras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.CrossCutting.Interface
{
    public interface ITokenService
    {
        public UsuarioToken GenerateToken(Usuario entity);
         bool IsValidUser(string username, string password);
    }
}
