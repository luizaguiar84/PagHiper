using Microsoft.Extensions.DependencyInjection;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Services;

namespace PagHiper.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceCollection(this IServiceCollection services)
        {
            
            services.AddTransient<IBoletoService, BoletoService>();
            services.AddTransient<IAlunoService, AlunoService>();
			
            return services;
        }

    }
}