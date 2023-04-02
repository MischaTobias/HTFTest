namespace HackTheFutureAPI.DTOs.FuelConsumption;

public class FuelQuantityPatch
{
    public int Id { get; set; }
    public double GallonQuantity { get; set; }

    public static explicit operator HTFDomain.Models.FuelConsumption(FuelQuantityPatch fuelQuantityPatch)
    {
        return new HTFDomain.Models.FuelConsumption()
        {
            Id = fuelQuantityPatch.Id,
            GallonQuantity = fuelQuantityPatch.GallonQuantity
        };
    }
}
