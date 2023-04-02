namespace HackTheFutureAPI.DTOs.TripCount;

public class NewTripCount
{
    public int Count { get; set; }
    public int EmissionTypeId { get; set; }

    public static explicit operator HTFDomain.Models.TripCount(NewTripCount tripCount)
    {
        return new HTFDomain.Models.TripCount()
        {
            Count = tripCount.Count,
            EmissionTypeId = tripCount.EmissionTypeId
        };
    }
}
