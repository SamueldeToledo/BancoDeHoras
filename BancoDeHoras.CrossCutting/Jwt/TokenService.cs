using BancoDeHoras.Domain.Entities;
using BancoDeHoras.Domain.Interfaces;
using Microsoft.AspNetCore.Authentication.BearerToken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.CrossCutting.Jwt
{
    public class TokenService
    {
        private readonly IUsuario _context;

        public TokenService(IUsuario context)
        {
            _context = context;
        }

        public ClaimsPrincipal GenerateToken(Usuario entity)
        {
            var Claims = new ClaimsPrincipal();
            if (IsValidUser(entity.Nome!, entity.Senha!))
            {
                var claimsPrincipal = new ClaimsPrincipal(
                    new ClaimsIdentity(
                        new[] { new Claim(entity.Nome!, entity.Senha!) },
                        BearerTokenDefaults.AuthenticationScheme
                    )
                );

                Claims = claimsPrincipal;
            }
            return Claims;
        }

        bool IsValidUser(string username, string password)
        {
            return _context.GetLogin(username, password).ToString()!.Length > 0;
        }
    }
}
