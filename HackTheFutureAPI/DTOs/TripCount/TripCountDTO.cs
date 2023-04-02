using HackTheFutureAPI.DTOs.EmissionType;
using HackTheFutureAPI.Generics;

namespace HackTheFutureAPI.DTOs.TripCount;

public class TripCountDTO : GenericEntityDTO
{
    public int Count { get; set; }
    public virtual EmissionTypeDTO EmissionType { get; set; } = default!;
    public static explicit operator TripCountDTO(HTFDomain.Models.TripCount TripCount)
    {
        return new TripCountDTO()
        {
            Id = TripCount.Id,
            Count = TripCount.Count,
            EmissionType = (EmissionTypeDTO)TripCount.EmissionType,
            CreatedDate = TripCount.CreatedDate,
            ModifiedDate = TripCount.ModifiedDate
        };
    }
}
