
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Rooms;

[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Rooms")]
public class RoomsGetController(IRoomRepository roomRepository) : RoomController(roomRepository)
{
    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await roomRepository.GetAll();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await roomRepository.GetById(id);
        if (category == null) return NotFound();
        return Ok(category);
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchCategories([FromQuery] string keyword)
    {
        var categories = await roomRepository.GetByKeyword(keyword);
        return Ok(categories);
    }
}
