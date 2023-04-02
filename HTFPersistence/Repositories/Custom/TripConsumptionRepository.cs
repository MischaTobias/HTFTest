using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;
using HTFPersistence.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace HTFPersistence.Repositories.Custom;

public class TripCountRepository : GenericRepository<TripCount>, ITripCountRepository
{
    private readonly HTFContext _context;
    public TripCountRepository(HTFContext context) : base(context)
    {
        _context = context;
    }

    public async Task<TripCount> GetWithEmissionTypeById(int Id)
    {
        return await _context.TripCounts
                            .Include(pdc => pdc.EmissionType)
                            .FirstAsync(pdc => pdc.Id == Id);
    }
}
