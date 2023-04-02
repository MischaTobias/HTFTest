namespace HackTheFutureAPI.DTOs.ElectricEnergyConsumption;

public class NewElectricEnergyConsumption
{
    public double KwQuantity { get; set; }
    public int ConsumptionTypeId { get; set; }
    public int EmissionTypeId { get; set; }
    public static explicit operator HTFDomain.Models.ElectricEnergyConsumption(NewElectricEnergyConsumption electricEnergyConsumption)
    {
        return new HTFDomain.Models.ElectricEnergyConsumption()
        {
            KwQuantity = electricEnergyConsumption.KwQuantity,
            ConsumptionTypeId = electricEnergyConsumption.ConsumptionTypeId,
            EmissionTypeId = electricEnergyConsumption.EmissionTypeId
        };
    }
}
