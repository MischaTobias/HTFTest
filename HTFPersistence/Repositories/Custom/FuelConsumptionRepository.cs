using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;
using HTFPersistence.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace HTFPersistence.Repositories.Custom;

public class FuelConsumptionRepository : GenericRepository<FuelConsumption>, IFuelConsumptionRepository
{
    private readonly HTFContext _context;
    public FuelConsumptionRepository(HTFContext context) : base(context)
    {
        _context = context;
    }

    public async Task<FuelConsumption> GetWithConsumptionAndEmissionTypeById(int Id)
    {
        return await _context.FuelConsumptions
                                .Include(fc => fc.EmissionType)
                                .Include(fc => fc.FuelType)
                                .FirstAsync(fc => fc.Id == Id);
    }
}
