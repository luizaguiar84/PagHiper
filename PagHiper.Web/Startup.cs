using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagHiper.Application.Interfaces;
using PagHiper.Application.Services;
using PagHiper.Infra;
using Paghiper.Infra.Sqlite;
using Paghiper.Infra.Sqlite.Context;

namespace PagHiper.Web
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public DatabaseConfiguration DatabaseConfiguration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
			DatabaseConfiguration = new DatabaseConfiguration(configuration);
		}

		

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			
			if (DatabaseConfiguration.DatabaseType == DatabaseType.Sqlite)
				services.AddSqLiteDependency();
			else
				throw new NotSupportedException("No database configuration found");


		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			using var dbContext = new CrudDbSqlite();
			//cria o banco
			dbContext.Database.EnsureCreated();


			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
