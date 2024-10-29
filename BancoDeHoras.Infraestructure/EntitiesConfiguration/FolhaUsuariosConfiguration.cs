using BancoDeHoras.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Infraestructure.EntitiesConfiguration
{
    internal class FolhaUsuariosConfiguration : IEntityTypeConfiguration<FolhaHorasUsuario>
    {
        public void Configure(EntityTypeBuilder<FolhaHorasUsuario> builder)
        {
            builder.ToTable("TB_BDH_HORAS");
            builder.HasKey(f=> f.Id);
            builder.Property(f => f.IdUsuario).HasColumnName("ID_USUARIO");
            builder.Property(f => f.HorarioBater).HasColumnName("HORARIO_BATER");
            builder.Property(f => f.HorarioSair).HasColumnName("HORARIO_SAIR");
        }
    }
}
