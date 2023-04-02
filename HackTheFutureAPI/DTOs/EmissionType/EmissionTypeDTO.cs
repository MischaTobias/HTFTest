using HackTheFutureAPI.Generics;

namespace HackTheFutureAPI.DTOs.EmissionType;

public class EmissionTypeDTO : GenericTypeDTO
{
    public static explicit operator EmissionTypeDTO(HTFDomain.Models.EmissionType emissionType)
    {
        return new EmissionTypeDTO()
        {
            Id = emissionType.Id,
            Name = emissionType.Name
        };
    }
}
