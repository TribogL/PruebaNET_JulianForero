using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.DTOs;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Employees;

[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeCreateController(IEmployeeRepository employeeRepository) : EmployeeController(employeeRepository)
{
    [HttpPost]
    public async Task<ActionResult<Employee>> Create(EmployeeDTO inputEmployee)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newEmployee = new Employee(inputEmployee.FirstName, inputEmployee.LastName,inputEmployee.Email,inputEmployee.IdentificationNumber, inputEmployee.Password);

        await _employeeRepository.Add(newEmployee);

        return Ok(newEmployee);
    }

}
