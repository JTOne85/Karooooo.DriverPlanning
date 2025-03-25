using Karooooo.Common.Configuration;
using Karooooo.AccessManagement.Jwt.Configuration;
using Karooooo.AccessManagement.Jwt;
using Karooooo.Common.Http.Rfc9457;
using Karooooo.Common.Logging.Options;

namespace Karooooo.DriverPlanning.App.Configuration;

public sealed class AuthenticatedServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddAuthenticated(configuration)
            .AddAuthorizationPolicies()
            .AddAuthorization()
            .AddAuthentication()
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = JwtBearerAuthentication.TokenValidationParameters(configuration);

                var elasticCloudOptions = configuration.GetSection("LoggingOptions")?.Get<LoggingOptions>()?.ElasticCloudOptions;

                var serviceProvider = services.BuildServiceProvider();
                var logger = serviceProvider.GetRequiredService<ILogger<JwtBearerEventsConfigurator>>();
                var jwtBearerEventsFactory = new JwtBearerEventsConfigurator(logger, elasticCloudOptions);

                o.Events = jwtBearerEventsFactory.Configure();
            });
    }
}
