using HackTheFutureAPI.DTOs.ConsumptionType;
using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using Microsoft.AspNetCore.Mvc;

namespace HackTheFutureAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class ConsumptionTypeController : ControllerBase
{
    private readonly IConsumptionTypeRepository _consumptionTypeRepository;

    public ConsumptionTypeController(IConsumptionTypeRepository consumptionTypeRepository)
    {
        _consumptionTypeRepository = consumptionTypeRepository;
    }

    public async Task<IActionResult> GetAllConsumptionTypes()
    {
        var consumptionTypes = await _consumptionTypeRepository.GetAllAsync();
        var consumptionTypesDTO = consumptionTypes.Select(ct => (ConsumptionTypeDTO)ct);
        return Ok(consumptionTypesDTO);
    }

    [HttpPost]
    public async Task<IActionResult> CreateConsumptionType(NewConsumptionTypeDTO consumptionType)
    {
        var newCT = (ConsumptionType)consumptionType;
        await _consumptionTypeRepository.AddAsync(newCT);
        return Created($"/ConsumptionType/{newCT.Id}", (ConsumptionTypeDTO)newCT);
    }
}