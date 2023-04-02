using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;
using HTFPersistence.Repositories.Generic;

namespace HTFPersistence.Repositories.Custom;

public class ConsumptionTypeRepository : GenericRepository<ConsumptionType>, IConsumptionTypeRepository
{
    public ConsumptionTypeRepository(HTFContext context) : base(context)
    {

    }
}
