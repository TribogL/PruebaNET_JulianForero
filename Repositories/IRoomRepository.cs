
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Model;

namespace PruebaNET_JulianForero.Repositories;

public interface IRoomRepository
{
    Task<IEnumerable<Room>> GetAll();
    Task<Room?> GetById(int id);
    Task<IEnumerable<Room>> GetByKeyword(string keyword);
    Task<Room> Create(RoomDTO roomdto);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}