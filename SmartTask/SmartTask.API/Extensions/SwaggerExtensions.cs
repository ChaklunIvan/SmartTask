namespace SmartTask.API.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwaggerGenerator(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ArmeniacaApricot API", Version = "v1" });
            });
            return services;
        }
    }
}
