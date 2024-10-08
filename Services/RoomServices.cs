
using Microsoft.EntityFrameworkCore;
using PruebaNET_JulianForero.Data;
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Services;
public class RoomServices : IRoomRepository
{
    private readonly ApplicationDbContext _context;

    public RoomServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Room> Create(RoomDTO roomDto)
    {
        var room = new Room(roomDto.RoomNumber,
        roomDto.RoomTypeId,
        roomDto.PricePerNight,
        roomDto.Availability,
        roomDto.MaxOccupancyPerson);

        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();
        return room;
    }

    public async Task Delete(int id)
    {
        var room = await GetById(id);
        if (room! == null)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }
    }
     public async Task<bool> CheckExistence(int id)
    {

        try
        {
            return await _context.Rooms.AnyAsync(v => v.Id == id);
        }

        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar la papa a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un erro inesperado al agregar la papa:", ex);
        }
    }

    public async Task<IEnumerable<Room>> GetAll()
    {
        return await _context.Rooms.ToListAsync();
    }

    public async Task<Room?> GetById(int id)
    {
        return await _context.Rooms.FindAsync(id);
    }

    public async Task<IEnumerable<Room>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Rooms.Where(pc => pc.RoomNumber.Contains(keyword)).ToListAsync();
    }

}
