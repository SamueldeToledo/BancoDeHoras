using AutoMapper;
using BancoDeHoras.Application.DTO;
using BancoDeHoras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FolhaHorasUsuarioDTO, FolhaHorasUsuario>().ReverseMap();
            CreateMap<MarcaPontoDTO, MarcaPonto>().ReverseMap();
        }
    }
}
