
using PruebaNET_JulianForero.Data;
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Services;
public class RoomTypeServices : IRoomTypeRepository
{
    private readonly ApplicationDbContext _context;

    public RoomTypeServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<RoomType> Create(RoomTypeDTO roomdto)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RoomType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<RoomType?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RoomType>> GetByKeyword(string keyword)
    {
        throw new NotImplementedException();
    }

    public async Task Update(int id, RoomType roomTypeDTO)
    {
        var roomType = await GetById(id);
        if (roomType == null) return;


        roomType.Name = roomTypeDTO.Name.ToLower().Trim();
        roomType.Description = roomTypeDTO.Description.ToLower().Trim();
        await _context.SaveChangesAsync();
    }
}
