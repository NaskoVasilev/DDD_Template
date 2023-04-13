using Microsoft.Extensions.DependencyInjection;

namespace DDD_Template.Web
{
    public static class WebConfiguration
    {
        public static IServiceCollection AddWebComponents(this IServiceCollection services)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson();

            return services;
        }
    }
}
