
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Model;

namespace PruebaNET_JulianForero.Repositories;

public interface IRoomTypeRepository
{
    Task<IEnumerable<RoomType>> GetAll();
    Task<RoomType?> GetById(int id);
    Task<IEnumerable<RoomType>> GetByKeyword(string keyword);
    Task<RoomType> Create(RoomTypeDTO roomTypeDTO);
    Task Update(int id, RoomType roomTypeDTO);
    Task Delete(int id);

}
