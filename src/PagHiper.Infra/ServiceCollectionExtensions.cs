using System;
using Microsoft.Extensions.DependencyInjection;
using PagHiper.Infra.Repositories;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Infra
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddInfraDependency(this IServiceCollection services)
		{
			// Registro dos repositórios
			services.AddTransient<IAlunoRepository, AlunoRepository>();
			services.AddTransient<IBoletoRepository, BoletoRepository>();
			services.AddTransient<ILeadRepository, LeadRepository>();
			
			return services;
		}
    }
}
