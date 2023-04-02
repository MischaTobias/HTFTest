using HackTheFutureAPI.DTOs.EmissionType;
using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using Microsoft.AspNetCore.Mvc;

namespace HackTheFutureAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class EmissionTypeController : ControllerBase
{
    private readonly IEmissionTypeRepository _emissionTypeRepository;

    public EmissionTypeController(IEmissionTypeRepository EmissionTypeRepository)
    {
        _emissionTypeRepository = EmissionTypeRepository;
    }

    public async Task<IActionResult> GetAllEmissionTypes()
    {
        var emissionTypes = await _emissionTypeRepository.GetAllAsync();
        var emissionTypesDTO = emissionTypes.Select(et => (EmissionTypeDTO)et);
        return Ok(emissionTypesDTO);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmissionType(NewEmissionTypeDTO emissionType)
    {
        var newET = (EmissionType)emissionType;
        await _emissionTypeRepository.AddAsync(newET);
        return Created($"/EmissionType/{newET.Id}", (EmissionTypeDTO)newET);
    }
}