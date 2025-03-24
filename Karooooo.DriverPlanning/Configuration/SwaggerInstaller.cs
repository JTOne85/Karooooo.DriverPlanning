using FastEndpoints.Swagger;
using Karooooo.Common.Configuration;

namespace Karooooo.DriverPlanning.App.Configuration
{
    public class SwaggerInstaller: IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.SwaggerDocument();
            
        }
    }
}
