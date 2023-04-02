using HTFDomain.Repositories.Custom;
using Microsoft.AspNetCore.Mvc;

namespace HackTheFutureAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class StaticticsController : ControllerBase
{
    private readonly IStatisticsRepository _statisticsRepository;

    public StaticticsController(IStatisticsRepository statisticsRepository)
    {
        _statisticsRepository = statisticsRepository;
    }
}