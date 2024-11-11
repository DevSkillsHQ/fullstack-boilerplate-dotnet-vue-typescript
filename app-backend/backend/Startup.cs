using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add CORS policy
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder.WithOrigins("*") // Allow all origins
                                    .AllowAnyHeader()
                                    .AllowAnyMethod());
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            // Use the CORS policy
            app.UseCors("AllowSpecificOrigin");

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}