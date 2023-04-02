using HTFDomain.Models;
using HTFDomain.Repositories.Generic;

namespace HTFDomain.Repositories.Custom;

public interface IFuelConsumptionRepository : IGenericRepository<FuelConsumption>
{
    Task<FuelConsumption> GetWithConsumptionAndEmissionTypeById(int Id);
}
