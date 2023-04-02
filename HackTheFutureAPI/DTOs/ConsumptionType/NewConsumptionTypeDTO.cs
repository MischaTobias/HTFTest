namespace HackTheFutureAPI.DTOs.ConsumptionType;

public class NewConsumptionTypeDTO
{
    public string Name { get; set; } = default!;

    public static explicit operator HTFDomain.Models.ConsumptionType(NewConsumptionTypeDTO consumptionTypeDTO)
    {
        return new HTFDomain.Models.ConsumptionType()
        {
            Name = consumptionTypeDTO.Name
        };
    }
}
