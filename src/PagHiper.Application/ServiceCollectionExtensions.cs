using Microsoft.Extensions.DependencyInjection;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Services;

namespace PagHiper.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            
            //services.AddTransient<IBoletoService, BoletoService>();
            services.AddTransient<IAlunoService, AlunoService>();
            //services.AddTransient<IEnderecoService, EnderecoService>();
			
            return services;
        }

    }
}