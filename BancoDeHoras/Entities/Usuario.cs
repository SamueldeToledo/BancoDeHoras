using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BancoDeHoras.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [JsonIgnore]
        public string? Nome { get; set; }
        [JsonIgnore]
        public string? Senha { get; set; }
        [JsonIgnore]
        public bool Status { get; set; }
        [JsonIgnore]
        public DateTime DatCri { get; set; }
        [JsonIgnore]
        public DateTime DatAtl { get; set; }
    }
}
