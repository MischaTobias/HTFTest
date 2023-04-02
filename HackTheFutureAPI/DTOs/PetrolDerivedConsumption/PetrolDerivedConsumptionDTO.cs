using HackTheFutureAPI.DTOs.ConsumptionType;
using HackTheFutureAPI.DTOs.EmissionType;
using HackTheFutureAPI.Generics;

namespace HackTheFutureAPI.DTOs.PetrolDerivedConsumption;

public class PetrolDerivedConsumptionDTO : GenericEntityDTO
{
    public double Quantity { get; set; }
    public virtual ConsumptionTypeDTO ConsumptionType { get; set; } = default!;
    public virtual EmissionTypeDTO EmissionType { get; set; } = default!;
    public static explicit operator PetrolDerivedConsumptionDTO(HTFDomain.Models.PetrolDerivedConsumption petrolDerivedConsumption)
    {
        return new PetrolDerivedConsumptionDTO()
        {
            Id = petrolDerivedConsumption.Id,
            Quantity = petrolDerivedConsumption.Quantity,
            ConsumptionType = (ConsumptionTypeDTO)petrolDerivedConsumption.ConsumptionType,
            EmissionType = (EmissionTypeDTO)petrolDerivedConsumption.EmissionType,
            CreatedDate = petrolDerivedConsumption.CreatedDate,
            ModifiedDate = petrolDerivedConsumption.ModifiedDate
        };
    }
}
