using AutoMapper;
using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using BancoDeHoras.Domain.Entities;
using BancoDeHoras.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.Service
{
    public class FolhaHorasUsuarioService : IFolhaHorasUsuarioService
    {
        private readonly IRepository<FolhaHorasUsuario> _context;
        private readonly IMapper _mapper;

        public FolhaHorasUsuarioService(IRepository<FolhaHorasUsuario> context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<FolhaHorasUsuarioDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<FolhaHorasUsuarioDTO> GetAll()
        {
            try
            {
                var DTO =  _context.GetAll();
                return _mapper.Map<IList<FolhaHorasUsuarioDTO>>(DTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null!;
            }
           
        }

        public void Post(FolhaHorasUsuarioDTO entity)
        {
            _context.Post(_mapper.Map<FolhaHorasUsuario>(entity));
            _context.Commit();
        }

        public void Put(FolhaHorasUsuarioDTO entity)
        {
            _context.Put(_mapper.Map<FolhaHorasUsuario>(entity));
            _context.Commit();
        }

        public void Delete(FolhaHorasUsuarioDTO entity)
        {
            _context.Delete(_mapper.Map<FolhaHorasUsuario>(entity));
            _context.Commit();
        }
    }
}
