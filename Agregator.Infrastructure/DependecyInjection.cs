using Agregator.Infrastructure.Persistence.DataBase;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Agregator.Infrastructure.Persistence;
using Agregator.Application.Common.Interfaces.UserService;
using Agregator.Infrastructure.Common.UserService;

namespace Agregator.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationContext>(o => o.UseInMemoryDatabase("agregator_db"));
        services.AddScoped<UnitOfWork>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }

}
