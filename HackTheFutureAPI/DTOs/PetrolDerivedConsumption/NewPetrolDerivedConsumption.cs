namespace HackTheFutureAPI.DTOs.PetrolDerivedConsumption;

public class NewPetrolDerivedConsumption
{
    public double Quantity { get; set; }
    public int ConsumptionTypeId { get; set; }
    public int EmissionTypeId { get; set; }

    public static explicit operator HTFDomain.Models.PetrolDerivedConsumption(NewPetrolDerivedConsumption petrolDerivedConsumption)
    {
        return new HTFDomain.Models.PetrolDerivedConsumption()
        {
            Quantity = petrolDerivedConsumption.Quantity,
            ConsumptionTypeId = petrolDerivedConsumption.ConsumptionTypeId,
            EmissionTypeId = petrolDerivedConsumption.EmissionTypeId
        };
    }
}
