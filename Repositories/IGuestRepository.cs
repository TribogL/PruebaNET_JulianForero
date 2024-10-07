
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Model;

namespace PruebaNET_JulianForero.Repositories;
public interface IGuestRepository
{

    Task<IEnumerable<Guest>> GetAllGuests();
    Task<Guest> GetGuestById(int id);
    Task AddGuest(GuestDTO guestDto);
    Task UpdateGuest(int id, GuestDTO guestDTO);
    Task Delete(int id);

}
