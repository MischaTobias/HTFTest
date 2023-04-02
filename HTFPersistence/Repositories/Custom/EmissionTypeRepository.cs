using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;
using HTFPersistence.Repositories.Generic;

namespace HTFPersistence.Repositories.Custom;

public class EmissionTypeRepository : GenericRepository<EmissionType>, IEmissionTypeRepository
{
    public EmissionTypeRepository(HTFContext context) : base(context)
    {

    }
}
