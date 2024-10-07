
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Guests;
[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestCreateController(IGuestRepository guestRepository)  : GuestController(guestRepository)
{
    [HttpPost]
    public async Task<IActionResult> AddGuest(GuestDTO newGuest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _guestRepository.AddGuest(newGuest);

        return Ok("Customer added successfully.");
    }

}
