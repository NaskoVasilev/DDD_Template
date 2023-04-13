using DDD_Template.Application.Contracts;
using DDD_Template.Infrastructure.Persistance;
using DDD_Template.Infrastructure.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDD_Template.Infrastructure
{
    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<ApplicationDbContext>(options => options
                    .UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)))
                .AddTransient<IInitializer, ApplicationDbInitializer>()
                .AddTransient(typeof(IRepository<>), typeof(DataRepository<>));
    }
}
