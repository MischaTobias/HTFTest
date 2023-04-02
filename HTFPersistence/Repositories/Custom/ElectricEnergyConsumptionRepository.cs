using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;
using HTFPersistence.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace HTFPersistence.Repositories.Custom;

public class ElectricEnergyConsumptionRepository : GenericRepository<ElectricEnergyConsumption>, IElectricEnergyConsumptionRepository
{
    private readonly HTFContext _context;
    public ElectricEnergyConsumptionRepository(HTFContext context) : base(context)
    {
        _context = context;
    }

    public async Task<ElectricEnergyConsumption> GetWithConsumptionAndEmissionTypeById(int Id)
    {
        return await _context.ElectricEnergyConsumptions
                            .Include(eec => eec.ConsumptionType)
                            .Include(eec => eec.EmissionType)
                            .FirstAsync(eec => eec.Id == Id);
    }
}
