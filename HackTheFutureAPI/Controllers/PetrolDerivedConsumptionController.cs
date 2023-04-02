using HackTheFutureAPI.DTOs.PetrolDerivedConsumption;
using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using Microsoft.AspNetCore.Mvc;

namespace HackTheFutureAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class PetrolDerivedConsumptionController : ControllerBase
{
    private readonly IPetrolDerivedConsumptionRepository _petrolDerivedConsumptionRepository;

    public PetrolDerivedConsumptionController(IPetrolDerivedConsumptionRepository petrolDerivedConsumptionRepository)
    {
        _petrolDerivedConsumptionRepository = petrolDerivedConsumptionRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePetrolDerivedConsumption(NewPetrolDerivedConsumption petrolDerivedConsumption)
    {
        var newPDC = (PetrolDerivedConsumption)petrolDerivedConsumption;
        await _petrolDerivedConsumptionRepository.AddAsync(newPDC);

        newPDC = await _petrolDerivedConsumptionRepository.GetWithConsumptionAndEmissionTypeById(newPDC.Id);
        return Created($"/PetrolDerivedConsumption/{newPDC.Id}", (PetrolDerivedConsumptionDTO)newPDC);
    }

    [HttpPatch]
    public async Task<IActionResult> PatchPetrolDerivedConsumption(PetrolDerivedQuantityPatch PetrolDerivedQuantityPatch)
    {
        var replacePDC = await _petrolDerivedConsumptionRepository.GetByIdAsync(PetrolDerivedQuantityPatch.Id);
        replacePDC.Quantity = PetrolDerivedQuantityPatch.Quantity;

        await _petrolDerivedConsumptionRepository.UpdateAsync(replacePDC);

        replacePDC = await _petrolDerivedConsumptionRepository.GetWithConsumptionAndEmissionTypeById(replacePDC.Id);
        return Created($"/PetrolDerivedConsumption/{replacePDC.Id}", (PetrolDerivedConsumptionDTO)replacePDC);
    }
}