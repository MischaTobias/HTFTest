using HTFDomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HTFPersistence.Configurations;

public class ConsumptionTypeConfiguration : IEntityTypeConfiguration<ConsumptionType>
{
    public void Configure(EntityTypeBuilder<ConsumptionType> builder)
    {
        builder.HasData(
            new ConsumptionType { Id = 1, Name = "Administrativo" },
            new ConsumptionType { Id = 2, Name = "Indirecto de proveedor" },
            new ConsumptionType { Id = 3, Name = "Logístico" },
            new ConsumptionType { Id = 4, Name = "Distribución" },
            new ConsumptionType { Id = 5, Name = "Operación" }
        );
    }
}

public class EmissionTypeConfiguration : IEntityTypeConfiguration<EmissionType>
{
    public void Configure(EntityTypeBuilder<EmissionType> builder)
    {
        builder.HasData(
            new EmissionType { Id = 1, Name = "Directa" },
            new EmissionType { Id = 2, Name = "Indirecta" },
            new EmissionType { Id = 3, Name = "Otra indirecta" }
        );
    }
}