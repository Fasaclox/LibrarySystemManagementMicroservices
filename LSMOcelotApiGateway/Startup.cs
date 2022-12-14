using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSMOcelotApiGateway
{
    public class Startup
    {
       
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddOcelot();
            }
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                app.UseOcelot().Wait();
            }

       
    }
}
