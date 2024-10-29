using BancoDeHoras.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Infraestructure.EntitiesConfiguration
{
    public class MarcaPontoConfiguration : IEntityTypeConfiguration<MarcaPonto>
    {
        public void Configure(EntityTypeBuilder<MarcaPonto> builder)
        {
            builder.ToTable("TB_BDH_MARCA_PONTOS");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.IdUsuario).HasColumnName("ID_USUARIO");
            builder.Property(f => f.Falta).HasColumnName("FALTA");
            builder.Property(f => f.DataEntrada).HasColumnName("DATA_ENTRADA");
            builder.Property(f => f.DataSaida).HasColumnName("DATA_SAIDA");
        }
    }
}
