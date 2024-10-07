

using Microsoft.EntityFrameworkCore;
using PruebaNET_JulianForero.Data;
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Services;
public class GuestServices : IGuestRepository
{
    private readonly ApplicationDbContext _context;

    public GuestServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddGuest(GuestDTO guestDto)
    {
        var guest = new Guest(
                guestDto.FirstName,
                guestDto.LastName,
                guestDto.Email,
                guestDto.IdentificationNumber,
                guestDto.PhoneNumber,
                guestDto.BirthDate);

        await _context.Set<Guest>().AddAsync(guest);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Guest>> GetAllGuests()
    {
        return await _context.Set<Guest>().ToListAsync();
    }

    public async Task<Guest> GetGuestById(int id)
    {
        return await _context.Set<Guest>().FindAsync(id);
    }

    public async Task UpdateGuest(int id, GuestDTO guestDTO)
    {
        var guest = await GetGuestById(id);

        if (guest != null)
        {
            guest.FirstName = guestDTO.FirstName;
            guest.LastName = guestDTO.LastName;
            guest.PhoneNumber = guestDTO.PhoneNumber;
            guest.PhoneNumber = guestDTO.PhoneNumber;
            guest.Email = guestDTO.Email;

            _context.Set<Guest>().Update(guest);
            await _context.SaveChangesAsync();
        }

    }
     public async Task<bool> CheckExistence(int id)
    {

        try
        {
            return await _context.Guests.AnyAsync(v => v.Id == id);
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
    public async Task Delete(int id)
    {
        var guest = await _context.Guests.FindAsync(id);
        if (guest! == null)
        {
            _context.Guests.Remove(guest);
            await _context.SaveChangesAsync();
        }
    }
}
