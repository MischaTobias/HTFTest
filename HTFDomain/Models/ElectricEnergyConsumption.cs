using HTFDomain.Generics;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTFDomain.Models;

public class ElectricEnergyConsumption : GenericEntity
{
    public double KwQuantity { get; set; }
    public int ConsumptionTypeId { get; set; }
    [ForeignKey(nameof(ConsumptionTypeId))]
    public virtual ConsumptionType ConsumptionType { get; set; } = default!;
    public int EmissionTypeId { get; set; }
    [ForeignKey(nameof(EmissionTypeId))]
    public virtual EmissionType EmissionType { get; set; } = default!;
}
