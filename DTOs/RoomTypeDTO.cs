
using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JulianForero.DTOs;
public class RoomTypeDTO
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

}
