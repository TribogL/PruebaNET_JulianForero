
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Guests;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestUpdateController(IGuestRepository guestRepository)  : GuestController(guestRepository)
{
    [HttpPut]
    public async Task<IActionResult> UpdateGuest(int id, GuestDTO updateGuest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var customer = await _guestRepository.GetGuestById(id);

        if (customer == null)
            return NotFound();

        await _guestRepository.UpdateGuest(id, updateGuest);

        return NoContent();
    }

}
