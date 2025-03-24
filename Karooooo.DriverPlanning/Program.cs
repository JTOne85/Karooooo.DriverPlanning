using FastEndpoints;
using FastEndpoints.Swagger;
using Karooooo.DriverPlanning.App.Configuration;
using Serilog;

namespace Karooooo.DriverPlanning.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureLogging();
            var MyAllowedSpecificOrigins = "_myAllowedSpecificOrigin";
            ConfigureCors(builder, MyAllowedSpecificOrigins);

            // Add services to the container.
            builder.Services.AddAuthorization();

            ConfigurationManager config = builder.Configuration;
            builder.Configuration.SetBasePath(AppContext.BaseDirectory).AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true);


            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            AddFastEndpointsAndSwagger(builder);
            builder.Host.UseSerilog();

            ConfigurePersistence(builder);

            var app = builder.Build();

            app.UseCors(MyAllowedSpecificOrigins);
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseFastEndpoints().UseSwaggerGen();            
            app.Run();
        }

     

        private static void ConfigurePersistence(WebApplicationBuilder builder)
        {
            var configuration = builder.Configuration;            
            builder.Services.AddPersistenceServices2(builder);
        }

        private static void ConfigureCors(WebApplicationBuilder builder, string myAllowedSpecificOrigins)
        {
            
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: myAllowedSpecificOrigins,
                    policy =>
                    {
                        policy.AllowAnyOrigin();
                        policy.AllowAnyHeader();
                        policy.AllowAnyMethod();
                    });
            });
        }

        private static void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().WriteTo.File("logs/log.txt").CreateLogger();
        }

        private static void AddFastEndpointsAndSwagger(WebApplicationBuilder builder)
        {
            builder.Services.AddFastEndpoints(o => o.Assemblies = new[] { Presentation.AssemblyReference.Assembly }).SwaggerDocument();
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
