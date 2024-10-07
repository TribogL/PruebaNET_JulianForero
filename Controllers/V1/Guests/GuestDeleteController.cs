
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Guests;
[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestDeleteController(IGuestRepository guestRepository) : GuestController(guestRepository)
{

    [HttpDelete("{id}")]
    public async Task<ActionResult<Guest>> Delete(int id)
    {
        var guest = await _guestRepository.CheckExistence(id);
        if (guest == false)
        {
            return NotFound();
        }

        await _guestRepository.Delete(id);

        return NoContent();
    }


}
