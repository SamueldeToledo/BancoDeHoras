using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.DTO
{
    public class MarcaPontoDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public bool Falta { get; set; }
    }
}
