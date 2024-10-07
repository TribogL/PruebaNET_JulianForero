
using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JulianForero.DTOs;
public class GuestDTO
{
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string IdentificationNumber { get; set; }

    [Required]
    public string PhoneNumber { get; set; }
    
    [Required]
    public DateOnly BirthDate { get; set; }

}
