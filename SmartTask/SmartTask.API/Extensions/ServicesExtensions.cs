using SmartTask.Services;
using SmartTask.Services.Intefraces;

namespace SmartTask.API.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IContractService, ContractService>();

            return services;
        }
    }
}
