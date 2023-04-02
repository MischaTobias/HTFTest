using HTFDomain.Generics;

namespace HTFDomain.Models;

public class EmissionType : GenericType
{
    public virtual ICollection<FuelConsumption> FuelConsumptions { get; set; } = default!;
}
