
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JulianForero.Repositories;

namespace PruebaNET_JulianForero.Controllers.V1.Employees;
[ApiController]
[Route("api/v1/[controller]")]
public class EmployeeController(IEmployeeRepository _employeeRepository) : ControllerBase
{
    protected readonly IEmployeeRepository _employeeRepository = _employeeRepository;
}
