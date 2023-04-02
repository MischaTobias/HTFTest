using HTFDomain.Models;
using HTFDomain.Repositories.Generic;

namespace HTFDomain.Repositories.Custom;

public interface ITripCountRepository : IGenericRepository<TripCount>
{
    Task<TripCount> GetWithEmissionTypeById(int Id);
}
