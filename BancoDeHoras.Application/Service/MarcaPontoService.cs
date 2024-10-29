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
    public class MarcaPontoService : IMarcaPontoService
    {
        private readonly IRepository<MarcaPonto> _context;
        private readonly IMapper _mapper;

        public MarcaPontoService(IRepository<MarcaPonto> context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public MarcaPontoDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<MarcaPontoDTO> GetAll()
        {
            var DTO = _context.GetAll();
            return _mapper.Map<IList<MarcaPontoDTO>>(DTO);
        }

        public void Post(MarcaPontoDTO entity)
        {
            _context.Post(_mapper.Map<MarcaPonto>(entity));
            _context.Commit();
        }

        public void Put(MarcaPontoDTO entity)
        {
            _context.Put(_mapper.Map<MarcaPonto>(entity));
            _context.Commit();
        }
        public void Delete(MarcaPontoDTO entity)
        {
            _context.Delete(_mapper.Map<MarcaPonto>(entity));
            _context.Commit();
        }
    }
}
