using DDD_Template.Application.Contracts;
using DDD_Template.Web.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDD_Template.Web
{
    public static class WebConfiguration
    {
        public static IServiceCollection AddWebComponents(this IServiceCollection services)
        {
            services
                .AddScoped<ICurrentUser, CurrentUserService>()
                .AddControllers()
                .AddNewtonsoftJson();

            return services;
        }
    }
}
