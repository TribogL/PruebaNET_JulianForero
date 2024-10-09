
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Employees;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeDeleteController(IEmployeeRepository employeeRepository) : EmployeeController(employeeRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var employee = await _employeeRepository.CheckExistence(id);

        if (employee == false)
        {
            return NotFound();
        }

        await _employeeRepository.Delete(id);

        return NotFound();
    }

}
