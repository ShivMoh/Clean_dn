using System.Reflection;
using Application.Authentication.Commands.Register;
using Application.Common.Authentication;
using Application.Common.Behaviors;
using FluentValidation;
using Mapster;
using MapsterMapper;
using MediatR;
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

        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
        
        services.AddMediatR(config => {
            config.RegisterServicesFromAssemblies(assembly);
        });

        services.AddValidatorsFromAssembly(assembly);

        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));   
        // services.AddScoped<IPipelineBehavior<RegisterCommand, AuthenticationResponse>, ValidationBehaviour<RegisterCommand, AuthenticationResponse>>();

        return services;
    }
}