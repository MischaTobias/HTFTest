namespace HackTheFutureAPI.DTOs.PetrolDerivedConsumption;

public class PetrolDerivedQuantityPatch
{
    public int Id { get; set; }
    public double Quantity { get; set; }

    public static explicit operator HTFDomain.Models.PetrolDerivedConsumption(PetrolDerivedQuantityPatch petrolDerivedQuantityPatch)
    {
        return new HTFDomain.Models.PetrolDerivedConsumption()
        {
            Id = petrolDerivedQuantityPatch.Id,
            Quantity = petrolDerivedQuantityPatch.Quantity
        };
    }
}
