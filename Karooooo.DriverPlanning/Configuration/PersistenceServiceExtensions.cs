using Karooooo.DriverPlanning.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Karooooo.DriverPlanning.App.Configuration
{
    public static class PersistenceServiceExtensions
    {
        public static IServiceCollection AddPersistenceServices2(this IServiceCollection services, WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("Database") ?? throw new Exception("Database connection string is null.");


            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
            });

            return services;
        }
    }
}
