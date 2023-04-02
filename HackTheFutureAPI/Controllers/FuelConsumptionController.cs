using HackTheFutureAPI.DTOs.FuelConsumption;
using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using Microsoft.AspNetCore.Mvc;

namespace HackTheFutureAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class FuelConsumptionController : ControllerBase
{
    private readonly IFuelConsumptionRepository _fuelConsumptionRepository;

    public FuelConsumptionController(IFuelConsumptionRepository fuelConsumptionRepository)
    {
        _fuelConsumptionRepository = fuelConsumptionRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateFuelConsumption(NewFuelConsumption fuelConsumption)
    {
        var newFC = (FuelConsumption)fuelConsumption;
        await _fuelConsumptionRepository.AddAsync(newFC);

        newFC = await _fuelConsumptionRepository.GetWithConsumptionAndEmissionTypeById(newFC.Id);
        return Created($"/FuelConsumption/{newFC.Id}", (FuelConsumptionDTO)newFC);
    }

    [HttpPatch]
    public async Task<IActionResult> PatchFuelConsumption(FuelQuantityPatch fuelQuantityPatch)
    {
        var replaceFC = await _fuelConsumptionRepository.GetByIdAsync(fuelQuantityPatch.Id);
        replaceFC.GallonQuantity = fuelQuantityPatch.GallonQuantity;

        await _fuelConsumptionRepository.UpdateAsync(replaceFC);

        replaceFC = await _fuelConsumptionRepository.GetWithConsumptionAndEmissionTypeById(replaceFC.Id);
        return Created($"/FuelConsumption/{replaceFC.Id}", (FuelConsumptionDTO)replaceFC);
    }
}