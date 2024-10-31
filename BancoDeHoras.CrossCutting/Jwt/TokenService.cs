using BancoDeHoras.CrossCutting.Interface;
using BancoDeHoras.Domain.Entities;
using BancoDeHoras.Domain.Interfaces;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.CrossCutting.Jwt
{
    public class TokenService : ITokenService
    {
        private readonly IUsuario _context;
        private readonly IConfiguration _configuration;

        public TokenService(IUsuario context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public UsuarioToken GenerateToken(Usuario entity)
        {
            var Claims = new ClaimsPrincipal();
            if (IsValidUser(entity.Nome!, entity.Senha!))
            {

                var claims = new[]
                {
                 new Claim(JwtRegisteredClaimNames.Sub, entity.Nome!),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                 };

                // Configura a chave e o algoritmo de assinatura do token
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // Cria o token
                var token = new JwtSecurityToken(
                 issuer: _configuration["Jwt:Issuer"],
                 audience: _configuration["Jwt:Audience"],
                 claims: claims,
                 expires: DateTime.Now.AddHours(3),
                 signingCredentials: creds
                 );

                // Retorna o token JWT em formato string
                var usuarioDados = _context.GetLogin(entity.Nome, entity.Senha);
                return new UsuarioToken()
                {
                    Id= usuarioDados.Id,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Nome = entity.Nome,
                };
            }
            return new UsuarioToken();
        }

        public bool IsValidUser(string username, string password)
        {
            if (username != string.Empty && password != string.Empty && username != null && password != null)
                if (_context.GetLogin(username, password) is not null)
                    return true;

                else return false;

            else
                return false;
        }
    }
}
