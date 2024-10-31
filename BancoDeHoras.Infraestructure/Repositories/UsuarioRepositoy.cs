using BancoDeHoras.Domain.Entities;
using BancoDeHoras.Domain.Interfaces;
using BancoDeHoras.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Infraestructure.Repositories
{
    public class UsuarioRepositoy : IUsuario
    {
        private readonly AppDbContext _context;

        public UsuarioRepositoy(AppDbContext context)
        {
            _context = context;
        }

        public Usuario GetLogin(string nome, string senha)
        {
            var entity = _context.Usuarios.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);
            return entity!;
        }


    }
}
