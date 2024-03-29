using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

// FluentValidation.DependencyInjection
// MediatR
// Microsoft.Extensions.DependecyInjection
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        services.AddMediatR(config => {
            config.RegisterServicesFromAssemblies(assembly);
        });

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}