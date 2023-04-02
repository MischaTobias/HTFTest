using HTFDomain.Generics;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTFDomain.Models;

public class FuelConsumption : GenericEntity
{
    public double GallonQuantity { get; set; }
    public int ConsumptionTypeId { get; set; }
    [ForeignKey(nameof(ConsumptionTypeId))]
    public virtual ConsumptionType FuelType { get; set; } = default!;
    public int EmissionTypeId { get; set; }
    [ForeignKey(nameof(EmissionTypeId))]
    public virtual EmissionType EmissionType { get; set; } = default!;
}
