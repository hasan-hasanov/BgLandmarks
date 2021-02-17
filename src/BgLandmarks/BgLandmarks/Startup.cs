using DAL.Entities;
using DAL.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text.Json;

namespace BgLandmarks
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IGetLandmarksQuery, GetLandmarksQuery>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseRouting();

            app.Run(async context =>
            {
                IGetLandmarksQuery landmarksQuery = context.RequestServices.GetService<IGetLandmarksQuery>();
                List<Landmark> landmarks = landmarksQuery.Execute();

                await context.Response.WriteAsync(JsonSerializer.Serialize(landmarks));
            });
        }
    }
}
