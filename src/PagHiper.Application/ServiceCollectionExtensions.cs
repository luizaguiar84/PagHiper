using Microsoft.Extensions.DependencyInjection;
using PagHiper.Application.Directors;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Services;
using PagHiper.Domain.Entities;

namespace PagHiper.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            
            //services.AddTransient<IBoletoService, BoletoService>();
            services.AddTransient<IAlunoService, AlunoService>();
            services.AddTransient<ILeadAppService, LeadAppAppService>();
            
            services.AddTransient<ILeadCreator, LeadCreator>();
            return services;
        }

    }
}