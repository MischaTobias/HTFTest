using HTFDomain.Generics;

namespace HTFDomain.Models;

public class PetrolDerivedType : GenericType
{
    public virtual ICollection<PetrolDerivedConsumption> PetrolDerivedConsumptions { get; set; } = default!;
}
