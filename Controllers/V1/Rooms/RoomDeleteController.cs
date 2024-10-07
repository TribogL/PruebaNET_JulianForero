
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Rooms;
[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Rooms")]
public class RoomDeleteController(IRoomRepository roomRepository) : RoomController(roomRepository)
{
    [HttpDelete("{id}")]
    public async Task<ActionResult<Room>> Delete(int id)
    {
        var room = await _roomRepository.CheckExistence(id);
        if (room == false)
        {
            return NotFound();
        }

        await _roomRepository.Delete(id);

        return NoContent();
    }
}
