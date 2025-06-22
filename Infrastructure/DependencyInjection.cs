using Application.Common.Interfaces.Persistence;
using Infrastructure.DataContext;
using Infrastructure.Persistence.Interceptors;
using Infrastructure.Persistence.Repository;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

        var dbString = "server=localhost;database=ams_1;Integrated security=False;User Id=sa;Password=bocchiisLiterallym3;TrustServerCertificate=true;";

      

        services.AddDbContext<ApplicationDbContext>(options => {
            options.UseSqlServer(dbString);
        });

        services.AddScoped<PublishDomainEventInterceptor>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRepository, AlumniRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
 

        return services;
    }
}