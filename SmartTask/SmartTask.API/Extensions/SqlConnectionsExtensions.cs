using Microsoft.EntityFrameworkCore;
using SmartTask.DataBase;

namespace SmartTask.API.Extensions
{
    public static class SqlConnectionsExtensions
    {
        public static IServiceCollection ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SmartTaskDbContext>(opts =>
            opts.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("MSSQLConnection")));
            return services;
        }
    }
}
