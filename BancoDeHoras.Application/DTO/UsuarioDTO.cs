using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public bool Status { get; set; }
        public DateTime DatCri { get; set; }
        public DateTime DatAtl { get; set; }
    }
}
