using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PagHiper.Infra.Context;
using PagHiper.Infra.Postgres.Context;

namespace PagHiper.Infra.Postgres
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPostgresDependency(this IServiceCollection services,
            DatabaseConfiguration configuration)
        {
            services.AddDbContext<CrudDbContext, PostgresCrudDbContext>(options =>
            {
                options.EnableSensitiveDataLogging();
                //options.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
                //options.UseLoggerFactory();

                options.UseNpgsql(configuration.ConnectionString, options =>
                {
                    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });
            });


            return services;
        }
    }
}