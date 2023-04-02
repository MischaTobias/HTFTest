using HTFDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace HTFPersistence.Context;

public class HTFContext : DbContext
{
    public DbSet<EmissionType> EmissionTypes { get; set; } = default!;
    public DbSet<ConsumptionType> ConsumptionTypes { get; set; } = default!;
    public DbSet<FuelConsumption> FuelConsumptions { get; set; } = default!;
    public DbSet<ElectricEnergyConsumption> ElectricEnergyConsumptions { get; set; } = default!;
    public DbSet<PetrolDerivedConsumption> PetrolDerivedConsumptions { get; set; } = default!;
    public DbSet<TripCount> TripCounts { get; set; } = default!;

    public HTFContext(DbContextOptions<HTFContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
    }
}
