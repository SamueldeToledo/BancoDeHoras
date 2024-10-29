﻿using AutoMapper;
using BancoDeHoras.Application.DTO;
using BancoDeHoras.Application.Interfaces;
using BancoDeHoras.Domain.Entities;
using BancoDeHoras.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Application.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepository<Usuario> _context;
        private readonly IMapper _mapper;

        public UsuarioService(IRepository<Usuario> context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public UsuarioDTO Get(Expression<Func<UsuarioDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<UsuarioDTO> GetAll(Expression<Func<UsuarioDTO, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Post(UsuarioDTO entity)
        {
            var DTO = _mapper.Map<Usuario>(entity);
            _context.Post(DTO!);
            _context.Commit();
        }

        public void Put(UsuarioDTO entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(UsuarioDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
