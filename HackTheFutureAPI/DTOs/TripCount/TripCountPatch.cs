namespace HackTheFutureAPI.DTOs.TripCount;

public class TripCountPatch
{
    public int Id { get; set; }
    public int Count { get; set; }

    public static explicit operator HTFDomain.Models.TripCount(TripCountPatch TripCountPatch)
    {
        return new HTFDomain.Models.TripCount()
        {
            Id = TripCountPatch.Id,
            Count = TripCountPatch.Count
        };
    }
}
