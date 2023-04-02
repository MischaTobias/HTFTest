using HackTheFutureAPI.DTOs.ElectricEnergyConsumption;
using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using Microsoft.AspNetCore.Mvc;

namespace HackTheFutureAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class ElectricEnergyConsumptionController : ControllerBase
{
    private readonly IElectricEnergyConsumptionRepository _electricEnergyConsumptionRepository;

    public ElectricEnergyConsumptionController(IElectricEnergyConsumptionRepository electricEnergyConsumptionRepository)
    {
        _electricEnergyConsumptionRepository = electricEnergyConsumptionRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateElectricEnergyConsumption(NewElectricEnergyConsumption ElectricEnergyConsumption)
    {
        var newEEC = (ElectricEnergyConsumption)ElectricEnergyConsumption;
        await _electricEnergyConsumptionRepository.AddAsync(newEEC);

        newEEC = await _electricEnergyConsumptionRepository.GetWithConsumptionAndEmissionTypeById(newEEC.Id);
        return Created($"/ElectricEnergyConsumption/{newEEC.Id}", (ElectricEnergyConsumptionDTO)newEEC);
    }

    [HttpPatch]
    public async Task<IActionResult> PatchElectricEnergyConsumption(ElectricEnergyQuantityPatch electricEnergyQuantityPatch)
    {
        var replaceEEC = await _electricEnergyConsumptionRepository.GetByIdAsync(electricEnergyQuantityPatch.Id);
        replaceEEC.KwQuantity = electricEnergyQuantityPatch.KwQuantity;

        await _electricEnergyConsumptionRepository.UpdateAsync(replaceEEC);

        replaceEEC = await _electricEnergyConsumptionRepository.GetWithConsumptionAndEmissionTypeById(replaceEEC.Id);
        return Created($"/ElectricEnergyConsumption/{replaceEEC.Id}", (ElectricEnergyConsumptionDTO)replaceEEC);
    }
}