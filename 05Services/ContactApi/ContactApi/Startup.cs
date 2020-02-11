using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace ContactApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string AllMyOrigins = "_allMyOrigins";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ContactStore>();
            services.AddControllers(options =>
            {
                /*
                 By default, when the framework detects that the request is coming from a browser:
                        The Accept header is ignored. The content is returned in JSON, unless otherwise configured*/
                options.RespectBrowserAcceptHeader = true; // false by default
            });
              //.AddXmlSerializerFormatters();// this will enable to accept the headers from client in whatever format
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Contact API", Version = "v1" });
            });
            //services.AddCors(options=> {
            //    // this is a default policy that makes all clients to access your API
            //    //options.AddDefaultPolicy(builder=>
            //    //{ 
            //    //builder.AllowAnyOrigin();
            //    //});
            //    options.AddPolicy(AllMyOrigins,builder=> {
            //        builder.WithOrigins("http://localhost:44321")
            //        .AllowAnyMethod()
            //        .AllowAnyHeader();
            //    });
            services.AddCors(options=>
            {
                options.AddPolicy(AllMyOrigins, b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var swaggerOptions = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);
            app.UseSwagger(options=>
            {
                options.RouteTemplate = swaggerOptions.JsonRoute;
            });
            app.UseSwaggerUI(options=>
            {
                //options.SwaggerEndpoint("/swagger/v1/swagger.json", swaggerOptions.Description);
                options.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description);
            });
            app.UseCors(AllMyOrigins);
            app.UseRouting();           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
