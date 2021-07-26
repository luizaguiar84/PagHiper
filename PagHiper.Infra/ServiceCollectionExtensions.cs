using Microsoft.Extensions.DependencyInjection;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Services;

namespace PagHiper.Infra
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddInfraDependency(this IServiceCollection services)
		{
			// Registro dos repositórios
			services.AddTransient<IBoletoService, BoletoService>();
			
			return services;
		}
    }
}
