using BancoDeHoras.Application.Interfaces;
using BancoDeHoras.Application.Mappings;
using BancoDeHoras.Application.Service;
using BancoDeHoras.CrossCutting.Interface;
using BancoDeHoras.CrossCutting.Jwt;
using BancoDeHoras.Domain.Interfaces;
using BancoDeHoras.Infraestructure.Context;
using BancoDeHoras.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BancoDeHoras.CrossCutting.Ioc
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("BloggingDatabase")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IFolhaHorasUsuarioService, FolhaHorasUsuarioService>();
            services.AddScoped<IUsuario, UsuarioRepositoy>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IMarcaPontoService, MarcaPontoService>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
