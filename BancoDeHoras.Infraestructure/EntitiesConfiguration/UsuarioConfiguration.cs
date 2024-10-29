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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_BDH_USUARIO");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Nome).HasColumnName("NOME");
            builder.Property(f => f.Senha).HasColumnName("SENHA");
            builder.Property(f => f.DatCri).HasColumnName("DATACRI");
            builder.Property(f => f.DatAtl).HasColumnName("DATATL");
        }
    }
}
