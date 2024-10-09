
using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JulianForero.DTOs;

public class EmployeeDTO
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string IdentificationNumber{ get; set; }
    
    [Required]
    public string Password { get; set; }

}
