namespace HTFDomain.Repositories.Custom;

public interface IStatisticsRepository
{
    public double GetAnnualFuelPercentageByCategoryId(int categoryId);
    public List<double> GetMonthlyAverageFuelGallonsConsumption(int year);
    public double GetMostImpactingSegmentPercentage();
    public List<double> GetMonthlyAverageKwOnPackagingPlant(int year);
    public List<double> GetMonthlyAverageKwConsumption(int year);
    public List<double> GetMonthlyAveragePetrolDerivedConsumptionByType(int petrolDerivedType, int year);
    public List<double> GetMonthlyCountOfTripsByTeam(int teamId, int year);
    public List<double> GetMonthlyUsageOfOils();
    public int GetMonthWithLessRefrigeringLosses();
    public int GetMonthWithMostFuelUsage();
    public int GetMonthWithLessFuelUsage();
}
