using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Alicunde.Infraestructure;

public static class DependecyInjection
{
    #region Public Methods

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var databaseString = configuration.GetConnectionString("Database");

        services.AddDbContext<AlicundeDbContext>(options =>
        {
            options.UseSqlServer(databaseString);
        });

        return services;
    }

    #endregion Public Methods
}