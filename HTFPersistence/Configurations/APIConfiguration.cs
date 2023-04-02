using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;
using HTFPersistence.Repositories.Custom;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HTFPersistence.Configurations;

public static class APIConfiguration
{
    public static IServiceCollection ConfigureAPI(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HTFContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("HTFDB") ?? "No Connection String";
            options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString),
                b => b.MigrationsAssembly(typeof(HTFContext).Assembly.FullName)
            );
        });

        services.AddTransient<IConsumptionTypeRepository, ConsumptionTypeRepository>();
        services.AddTransient<IEmissionTypeRepository, EmissionTypeRepository>();
        services.AddTransient<IFuelConsumptionRepository, FuelConsumptionRepository>();
        services.AddTransient<IElectricEnergyConsumptionRepository, ElectricEnergyConsumptionRepository>();
        services.AddTransient<IPetrolDerivedConsumptionRepository, PetrolDerivedConsumptionRepository>();
        services.AddTransient<ITripCountRepository, TripCountRepository>();

        return services;
    }
}
