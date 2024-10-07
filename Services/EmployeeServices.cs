using Microsoft.EntityFrameworkCore;
using PruebaNET_JulianForero.Data;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Services
{
    public class EmployeeServices : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "El empleado no puede ser nulo");
            }

            try
            {
                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al agregar el empleado a la base de datos", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de agregar el empleado", exi);
            }
        }

        public async Task<bool> CheckExistence(int id)
        {
            try
            {
                return await _context.Employees.AnyAsync(u => u.Id == id);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de busacar el empleado", exi);
            }
        }

        public async Task Delete(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException(nameof(employee), "El empleado no puede ser nulo.");
            }
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByEmail(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(u => u.Email == email); ;
        }

        public async Task<Employee?> GetById(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetByKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return await GetAll();
            }

            return await _context.Employees.Where(u => u.FirstName.Contains(keyword)).ToListAsync();

        }

        public async Task Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "el empleado no puede ser nulo");
            }

            try
            {
                _context.Entry(employee).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {

                throw new Exception("Error al actualizar el empleado en la base de datos", dbExi);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el empleado.", ex);
            }
        }

    }
}