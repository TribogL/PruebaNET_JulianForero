
using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JulianForero.DTOs;
public class BookingDTO
{
    [Required]
    public int RoomId { get; set; }

    [Required]
    public int GuestId { get; set; }

   [Required]
    public int EmployeeId { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

   [Required]
    public DateTime EndDate { get; set; }

    [Required]
    public double TotalCost { get; set; }

}
