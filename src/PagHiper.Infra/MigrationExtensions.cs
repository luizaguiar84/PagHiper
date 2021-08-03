﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PagHiper.Infra.Context;

namespace PagHiper.Infra
{
	public static class MigrationExtensions
	{
		public static void MigrateDatabase(this IServiceProvider provider)
		{
			Task.Factory.StartNew(() =>
			{
				using var scope = provider.CreateScope();
				using var context = scope.ServiceProvider.GetRequiredService<CrudDbContext>();
				context.Database.Migrate();
			});
		}
	}
}