
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Guests;
[ApiController]
[Route("api/v1/[controller]")]
public class GuestController(IGuestRepository _guestRepository) : ControllerBase
{
    protected readonly IGuestRepository _guestRepository = _guestRepository;
}

