using HTFDomain.Generics;

namespace HTFDomain.Models;

public class ConsumptionType : GenericType
{
    public virtual ICollection<FuelConsumption> FuelConsumptions { get; set; } = default!;
}
