using DDD_Template.Domain.Common;
using DDD_Template.Domain.Factories;
using DDD_Template.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DDD_Template.Domain
{
    public static class DomainConfiguration
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
            => services
                .Scan(scan => scan
                    .FromCallingAssembly()
                    .AddClasses(classes => classes
                        .AssignableTo(typeof(IFactory<>)))
                    .AsMatchingInterface()
                    .WithTransientLifetime())
                .AddTransient<IInitialData, TestData>();
    }
}
