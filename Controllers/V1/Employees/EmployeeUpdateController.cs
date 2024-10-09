using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Employees;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeUpdateController(IEmployeeRepository employeeRepository) : EmployeeController(employeeRepository)
{
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, EmployeeDTO updateEmployee)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var checkUser = await _employeeRepository.CheckExistence(id);

        if (!checkUser)
        {
            return NotFound();
        }

        var employee = await _employeeRepository.GetById(id);

        if (employee == null)
        {
            return NotFound();
        }

        // Actualizamos los campos del usuario
        employee.FirstName = updateEmployee.FirstName;
        employee.LastName = updateEmployee.LastName;
        employee.Email = updateEmployee.Email;
        employee.IdentificationNumber = updateEmployee.IdentificationNumber;
        employee.Password = updateEmployee.Password;

        await _employeeRepository.Update(employee);
        return NoContent();
    }

}
