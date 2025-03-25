using FastEndpoints;
using FastEndpoints.Swagger;
using Karooooo.AccessManagement.Jwt;
using Karooooo.Common.Http.RestClients.AccessManagement.Configuration;
using Karooooo.Common.Http.Rfc9457.Middleware;
using Karooooo.Common.Http.Rfc9457.Model;
using Karooooo.Common.Logging;
using Karooooo.Common.Logging.Options;
using Karooooo.Common.Configuration;
using Karooooo.DriverPlanning.App.Configuration;
using Serilog;

namespace Karooooo.DriverPlanning.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var MyAllowedSpecificOrigins = "_myAllowedSpecificOrigin";

            ConfigurationManager config = builder.Configuration;

            builder.Configuration.SetBasePath(AppContext.BaseDirectory).AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true);
            builder.Services.AddLoggingSupportFromLoggingOptions(builder.Host, builder.Configuration);
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowedSpecificOrigins,
                    policy =>
                    {
                        policy.AllowAnyOrigin();
                        policy.AllowAnyHeader();
                        policy.AllowAnyMethod();
                    });
            });
            builder.Services.InstallServices(builder.Configuration, typeof(AssemblyReference).Assembly);
            builder.Services.AddAccessManagementWebApi(builder.Configuration);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddFastEndpoints(o => o.Assemblies = new[] { Presentation.AssemblyReference.Assembly }).SwaggerDocument(d => d.DocumentSettings = s =>
            {
                s.DocumentName = "Initial Driver Planning Version";
                s.Title = "Driver Planning API";
                s.Version = "v0";
            });

            // Add services to the container.
            builder.Services.AddAuthorizationPolicies();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            ConfigurePersistence(builder);

            var app = builder.Build();

            app.UseMiddleware<ProblemDetailsMiddleware>()
               .UseCors()
               .UseAuthentication()
               .UseAuthorization().UseFastEndpoints(c =>
               {
                   c.Versioning.Prefix = "v";
                   c.Serializer.Options.PropertyNamingPolicy = null;
                   var elasticCloudOptions = builder.Configuration.GetSection("LoggingOptions")?.Get<LoggingOptions>()?.ElasticCloudOptions;
                   c.Errors.ResponseBuilder = (failures, httpContext, _) => ModelValidationProblemDetails.Create(httpContext.Request.Path, failures, elasticCloudOptions);
               }).UseHttpsRedirection().UseSwaggerGen();

            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }            
           
            app.Run();
        }



        private static void ConfigurePersistence(WebApplicationBuilder builder)
        {
            var configuration = builder.Configuration;
            builder.Services.AddPersistenceServices2(builder);
        }

        private static void ConfigureCors(WebApplicationBuilder builder, string myAllowedSpecificOrigins)
        {


        }

        private static void ConfigureLogging(WebApplicationBuilder builder)
        {
            //Log.Logger = new LoggerConfiguration().WriteTo.Console().WriteTo.File("logs/log.txt").CreateLogger();

        }

        private static void AddFastEndpointsAndSwagger(WebApplicationBuilder builder)
        {

        }
    }
}
