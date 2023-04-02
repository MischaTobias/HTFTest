using HTFDomain.Models;
using HTFDomain.Repositories.Generic;

namespace HTFDomain.Repositories.Custom;

public interface IElectricEnergyConsumptionRepository : IGenericRepository<ElectricEnergyConsumption>
{
    Task<ElectricEnergyConsumption> GetWithConsumptionAndEmissionTypeById(int Id);
}
