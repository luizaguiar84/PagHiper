using Microsoft.Extensions.DependencyInjection;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Services;
using PagHiper.Infra.Repositories;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Infra
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddInfraDependency(this IServiceCollection services)
		{
			// Registro dos repositórios
			services.AddTransient<IBoletoService, BoletoService>();
			services.AddTransient<IAlunoRepository, AlunoRepository>();
			
			return services;
		}
    }
}
