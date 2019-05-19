using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebChef.Models;

namespace WebChef
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=localhost;Database=WebChef;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<UtilizadorContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<ReceitaContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<ReceitaUtilizadorContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<ReceitaPassoContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<PassoContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<AcaoContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<IngredienteContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<PassoIngredienteContext>(options => options.UseSqlServer(connection));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/UtilizadorView/LoginUtilizador/";
                        options.LogoutPath = "/UtilizadorView/Logout/";

                    });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
        }
    }
}
