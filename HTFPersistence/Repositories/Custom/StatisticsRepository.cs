using HTFDomain.Repositories.Custom;
using HTFPersistence.Context;

namespace HTFPersistence.Repositories.Custom;

public class StatisticsRepository : IStatisticsRepository
{
    private readonly HTFContext _context;
    public StatisticsRepository(HTFContext context)
    {
        _context = context;
    }

    public double GetAnnualFuelPercentageByCategoryId(int categoryId)
    {
        throw new NotImplementedException();
    }

    public List<double> GetMonthlyAverageFuelGallonsConsumption(int year)
    {
        throw new NotImplementedException();
    }

    public List<double> GetMonthlyAverageKwConsumption(int year)
    {
        throw new NotImplementedException();
    }

    public List<double> GetMonthlyAverageKwOnPackagingPlant(int year)
    {
        throw new NotImplementedException();
    }

    public List<double> GetMonthlyAveragePetrolDerivedConsumptionByType(int petrolDerivedType, int year)
    {
        throw new NotImplementedException();
    }

    public List<double> GetMonthlyCountOfTripsByTeam(int teamId, int year)
    {
        throw new NotImplementedException();
    }

    public List<double> GetMonthlyUsageOfOils()
    {
        throw new NotImplementedException();
    }

    public int GetMonthWithLessFuelUsage()
    {
        throw new NotImplementedException();
    }

    public int GetMonthWithLessRefrigeringLosses()
    {
        throw new NotImplementedException();
    }

    public int GetMonthWithMostFuelUsage()
    {
        throw new NotImplementedException();
    }

    public double GetMostImpactingSegmentPercentage()
    {
        throw new NotImplementedException();
    }
}
