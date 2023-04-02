using HackTheFutureAPI.DTOs.ConsumptionType;
using HackTheFutureAPI.DTOs.EmissionType;
using HackTheFutureAPI.Generics;

namespace HackTheFutureAPI.DTOs.FuelConsumption;

public class FuelConsumptionDTO : GenericEntityDTO
{
    public double GallonQuantity { get; set; }
    public virtual ConsumptionTypeDTO ConsumptionType { get; set; } = default!;
    public virtual EmissionTypeDTO EmissionType { get; set; } = default!;
    public static explicit operator FuelConsumptionDTO(HTFDomain.Models.FuelConsumption fuelComsumption)
    {
        return new FuelConsumptionDTO()
        {
            Id = fuelComsumption.Id,
            GallonQuantity = fuelComsumption.GallonQuantity,
            ConsumptionType = (ConsumptionTypeDTO)fuelComsumption.FuelType,
            EmissionType = (EmissionTypeDTO)fuelComsumption.EmissionType,
            CreatedDate = fuelComsumption.CreatedDate,
            ModifiedDate = fuelComsumption.ModifiedDate
        };
    }
}
