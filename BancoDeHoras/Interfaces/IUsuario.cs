using BancoDeHoras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Domain.Interfaces
{
    public interface IUsuario
    {
        public Usuario GetLogin(string nome, string senha);
    }
}
