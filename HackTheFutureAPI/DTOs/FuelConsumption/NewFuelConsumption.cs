namespace HackTheFutureAPI.DTOs.FuelConsumption;

public class NewFuelConsumption
{
    public double GallonQuantity { get; set; }
    public int ConsumptionTypeId { get; set; }
    public int EmissionTypeId { get; set; }

    public static explicit operator HTFDomain.Models.FuelConsumption(NewFuelConsumption fuelConsumption)
    {
        return new HTFDomain.Models.FuelConsumption()
        {
            GallonQuantity = fuelConsumption.GallonQuantity,
            ConsumptionTypeId = fuelConsumption.ConsumptionTypeId,
            EmissionTypeId = fuelConsumption.EmissionTypeId
        };
    }
}
