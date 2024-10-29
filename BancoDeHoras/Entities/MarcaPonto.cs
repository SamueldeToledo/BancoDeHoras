using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Domain.Entities
{
    public class MarcaPonto
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public bool Falta { get; set; }
        public int IdUsuario { get; set; }
    }
}
