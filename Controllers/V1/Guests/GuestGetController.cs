
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Guests;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Guests")]
public class GuestGetController(IGuestRepository guestRepository)  : GuestController(guestRepository)
{
    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await _guestRepository.GetAllGuests();
        return Ok(customers);
    }

    [HttpGet("Id")]
    public async Task<IActionResult> GetCustomerById(int id)
    {
        var guest = await _guestRepository.GetGuestById(id);

        if (guest == null)
            return NotFound();

        return Ok(guest);
    }

}
