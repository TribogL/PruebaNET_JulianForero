
using PruebaNET_JulianForero.Model;

namespace PruebaNET_JulianForero.Repositories;
public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAll();
    Task<Employee?> GetById(int id);
    Task<Employee?> GetByEmail(string email);
    Task<IEnumerable<Employee>> GetByKeyword(string keyword);
    Task Add(Employee employee);
    Task Update(Employee employee);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
