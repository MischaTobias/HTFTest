using HackTheFutureAPI.DTOs.TripCount;
using HTFDomain.Models;
using HTFDomain.Repositories.Custom;
using Microsoft.AspNetCore.Mvc;

namespace HackTheFutureAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class TripCountController : ControllerBase
{
    private readonly ITripCountRepository _tripCountRepository;

    public TripCountController(ITripCountRepository tripCountRepository)
    {
        _tripCountRepository = tripCountRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTripCount(NewTripCount tripCount)
    {
        var newTC = (TripCount)tripCount;
        await _tripCountRepository.AddAsync(newTC);

        newTC = await _tripCountRepository.GetWithEmissionTypeById(newTC.Id);
        return Created($"/TripCount/{newTC.Id}", (TripCountDTO)newTC);
    }

    [HttpPatch]
    public async Task<IActionResult> PatchTripCount(TripCountPatch tripCountPatch)
    {
        var replaceTC = await _tripCountRepository.GetByIdAsync(tripCountPatch.Id);
        replaceTC.Count = tripCountPatch.Count;

        await _tripCountRepository.UpdateAsync(replaceTC);

        replaceTC = await _tripCountRepository.GetWithEmissionTypeById(replaceTC.Id);
        return Created($"/TripCount/{replaceTC.Id}", (TripCountDTO)replaceTC);
    }
}