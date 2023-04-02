namespace HackTheFutureAPI.DTOs.ElectricEnergyConsumption;

public class ElectricEnergyQuantityPatch
{
    public int Id { get; set; }
    public double KwQuantity { get; set; }

    public static explicit operator HTFDomain.Models.ElectricEnergyConsumption(ElectricEnergyQuantityPatch electricEnergyQuantityPatch)
    {
        return new HTFDomain.Models.ElectricEnergyConsumption()
        {
            Id = electricEnergyQuantityPatch.Id,
            KwQuantity = electricEnergyQuantityPatch.KwQuantity
        };
    }
}
