using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Services;
using PagHiper.Infra;
using Paghiper.Infra.Sqlite.Context;

namespace Paghiper.Infra.Sqlite
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddSqLiteDependency(this IServiceCollection services)
		{
			//services
			//	.AddInfraDependency()
			//	.AddTnfDbContext<CrudDbContext, SqliteCrudDbContext>((config) =>
			//	{
			//		if (Constants.IsDevelopment())
			//		{
			//			config.DbContextOptions.EnableSensitiveDataLogging();
			//			config.DbContextOptions.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
			//			config.UseLoggerFactory();
			//		}

			//		if (config.ExistingConnection != null)
			//			config.DbContextOptions.UseSqlite(config.ExistingConnection);
			//		else
			//			config.DbContextOptions.UseSqlite(config.ConnectionString);
			//	});
			services.AddDbContext<CrudDbSqlite>();

			services.AddTransient<IBoletoService, BoletoService>();
			return services;
		}
    }


	
}
