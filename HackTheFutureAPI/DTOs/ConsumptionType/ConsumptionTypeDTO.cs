using HackTheFutureAPI.Generics;

namespace HackTheFutureAPI.DTOs.ConsumptionType;

public class ConsumptionTypeDTO : GenericTypeDTO
{
    public static explicit operator ConsumptionTypeDTO(HTFDomain.Models.ConsumptionType consumptionType)
    {
        return new ConsumptionTypeDTO()
        {
            Id = consumptionType.Id,
            Name = consumptionType.Name
        };
    }
}
