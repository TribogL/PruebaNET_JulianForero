
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Rooms;
[ApiController]
[Route("api/v1/[controller]")]

public class RoomController(IRoomRepository _roomRepository) : ControllerBase
{
    protected readonly IRoomRepository _roomRepository = _roomRepository;
}

