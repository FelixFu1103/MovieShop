using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Repositories;
using ApplicationCore.Entities;

namespace MovieShopMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IGenreService, GenresService>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<ICastService, CastService>();
            services.AddScoped<ICastRepository, CastRepository>();

            services.AddDbContext<MovieShopDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("MovieShopDbConnection"));
            });
            // services.AddScoped<IMovieService, MovieService2>();
            // 3rdy party IOC Autofac, Ninject
            // ASP.NET Core has buil;tin support for DI and it has built-in container
            // ASP.NET Framework there was no DI, Autofac, Ninject
            // Reflection ?
            // get me total number of methods and properties in a class
            // System.Relection
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Privacy}/{id?}");
            });
        }
    }
}
