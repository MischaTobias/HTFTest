using HTFDomain.Generics;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTFDomain.Models;

public class TripCount : GenericEntity
{
    public int Count { get; set; }
    public int EmissionTypeId { get; set; }
    [ForeignKey(nameof(EmissionTypeId))]
    public virtual EmissionType EmissionType { get; set; } = default!;
}
