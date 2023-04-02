namespace HackTheFutureAPI.DTOs.EmissionType;

public class NewEmissionTypeDTO
{
    public string Name { get; set; } = default!;

    public static explicit operator HTFDomain.Models.EmissionType(NewEmissionTypeDTO emissionTypeDTO)
    {
        return new HTFDomain.Models.EmissionType()
        {
            Name = emissionTypeDTO.Name
        };
    }
}
