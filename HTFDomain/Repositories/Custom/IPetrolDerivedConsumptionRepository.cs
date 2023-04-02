using HTFDomain.Models;
using HTFDomain.Repositories.Generic;

namespace HTFDomain.Repositories.Custom;

public interface IPetrolDerivedConsumptionRepository : IGenericRepository<PetrolDerivedConsumption>
{
    Task<PetrolDerivedConsumption> GetWithConsumptionAndEmissionTypeById(int Id);
}
