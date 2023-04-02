using HackTheFutureAPI.DTOs.ConsumptionType;
using HackTheFutureAPI.DTOs.EmissionType;
using HackTheFutureAPI.Generics;

namespace HackTheFutureAPI.DTOs.ElectricEnergyConsumption;

public class ElectricEnergyConsumptionDTO : GenericEntityDTO
{
    public double KwQuantity { get; set; }
    public virtual ConsumptionTypeDTO ConsumptionType { get; set; } = default!;
    public virtual EmissionTypeDTO EmissionType { get; set; } = default!;
    public static explicit operator ElectricEnergyConsumptionDTO(HTFDomain.Models.ElectricEnergyConsumption electricEnergyConsumption)
    {
        return new ElectricEnergyConsumptionDTO()
        {
            Id = electricEnergyConsumption.Id,
            KwQuantity = electricEnergyConsumption.KwQuantity,
            ConsumptionType = (ConsumptionTypeDTO)electricEnergyConsumption.ConsumptionType,
            EmissionType = (EmissionTypeDTO)electricEnergyConsumption.EmissionType,
            CreatedDate = electricEnergyConsumption.CreatedDate,
            ModifiedDate = electricEnergyConsumption.ModifiedDate
        };
    }
}
