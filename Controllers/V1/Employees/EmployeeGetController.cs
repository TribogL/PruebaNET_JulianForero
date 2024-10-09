using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Model;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Employees;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Employees")]
public class EmployeeGetController(IEmployeeRepository employeeRepository) : EmployeeController(employeeRepository)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
    {
        var user = await _employeeRepository.GetAll();
        return Ok(user);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetById(int id)
    {
        var user = await _employeeRepository.GetById(id);

        if (user == null)
        {
            return NotFound();
        }
        return user;
    }

    [HttpGet("serach/{keyword}")]
    public async Task<ActionResult<IEnumerable<Employee>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vasia");
        }

        var user = await _employeeRepository.GetByKeyword(keyword);

        if (!user.Any())
        {
            return NotFound("no se encontraron usuarios con concidencias");
        }

        return Ok(user);
    }
}
