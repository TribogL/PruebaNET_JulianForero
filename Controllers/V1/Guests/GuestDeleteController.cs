
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Guests;
[ApiController]
[Route("api/[controller]")]
public class GuestDeleteController(IGuestRepository guestRepository)  : GuestController(guestRepository)
{

}
