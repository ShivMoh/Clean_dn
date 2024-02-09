using Application.Common.Interfaces.Persistence;
using Infrastructure.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}