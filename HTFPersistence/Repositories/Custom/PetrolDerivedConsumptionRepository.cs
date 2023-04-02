using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;
using HTFPersistence.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace HTFPersistence.Repositories.Custom;

public class PetrolDerivedConsumptionRepository : GenericRepository<PetrolDerivedConsumption>, IPetrolDerivedConsumptionRepository
{
    private readonly HTFContext _context;
    public PetrolDerivedConsumptionRepository(HTFContext context) : base(context)
    {
        _context = context;
    }

    public async Task<PetrolDerivedConsumption> GetWithConsumptionAndEmissionTypeById(int Id)
    {
        return await _context.PetrolDerivedConsumptions
                            .Include(pdc => pdc.ConsumptionType)
                            .Include(pdc => pdc.EmissionType)
                            .FirstAsync(pdc => pdc.Id == Id);
    }
}
