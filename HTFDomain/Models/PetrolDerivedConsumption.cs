using HTFDomain.Generics;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTFDomain.Models;

public class PetrolDerivedConsumption : GenericEntity
{
    public double Quantity { get; set; }
    public int PetrolDerivedTypeId { get; set; }
    [ForeignKey(nameof(PetrolDerivedTypeId))]
    public virtual PetrolDerivedType PetrolDerivedType { get; set; } = default!;
    public int ConsumptionTypeId { get; set; }
    [ForeignKey(nameof(ConsumptionTypeId))]
    public virtual ConsumptionType ConsumptionType { get; set; } = default!;
    public int EmissionTypeId { get; set; }
    [ForeignKey(nameof(EmissionTypeId))]
    public virtual EmissionType EmissionType { get; set; } = default!;
}
