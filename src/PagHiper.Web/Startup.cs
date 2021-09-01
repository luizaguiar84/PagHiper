using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.DotNet.PlatformAbstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PagHiper.Application;
using PagHiper.Infra;
using PagHiper.Infra.MySql;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace PagHiper.Web
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		public DatabaseConfiguration DatabaseConfiguration { get; }
		public IHostEnvironment Environment { get; }

		public Startup(IConfiguration configuration, IHostEnvironment environment)
		{
			Configuration = configuration;
			Environment = environment;
			DatabaseConfiguration = new DatabaseConfiguration(configuration, Environment.IsProduction());
		}


		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();

			services.AddServices();
			services.AddInfraDependency();

			if (DatabaseConfiguration.DatabaseType == DatabaseType.MySQL)
				services.AddMySQLDependency(DatabaseConfiguration);
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
			//using var dbContext = new SqliteCrudDbContext();
			////cria o banco
			//dbContext.Database.EnsureCreated();


			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.ApplicationServices.MigrateDatabase();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
