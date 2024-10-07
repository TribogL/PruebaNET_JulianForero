

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_JulianForero.Model;

[Table("bookings")]
public class Booking
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("room_id")]
    public int RoomId { get; set; }

    [Column("guest_id")]
    public int GuestId { get; set; }

    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [Column("start_date")]
    public DateTime StartDate { get; set; }

    [Column("end_date")]
    public DateTime EndDate { get; set; }

    [Column("total_cost")]
    public double TotalCost { get; set; }


    // connection with foreign key

    // Foreign key to Employee
    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }

    // Foreign key to Guest
    [ForeignKey("GuestId")]
    public Guest Guest { get; set; }


    // Foreign key to Room
    [ForeignKey("RoomId")]
    public Room Room { get; set; }


    public Booking(int roomId, int guestId, int employeeId, DateTime startDate, DateTime endDate, double totalCost)
    {
        RoomId = roomId;
        GuestId = guestId;
        EmployeeId = employeeId;
        StartDate = startDate;
        EndDate = endDate;
        TotalCost = totalCost;
        
    }

}
