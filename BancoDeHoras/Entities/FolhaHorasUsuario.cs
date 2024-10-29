using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Domain.Entities
{
    public class FolhaHorasUsuario
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime HorarioBater { get; set; }
        public DateTime HorarioSair { get; set; }
    }
}
