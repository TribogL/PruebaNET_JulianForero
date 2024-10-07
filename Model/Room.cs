

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_JulianForero.Model;

[Table("rooms")]
public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }


    [Column("room_number")]
    public string RoomNumber { get; set; }


    [Column("room_type_id")]
    public int RoomTypeId { get; set; }

    [Column("price_per_night")]
    public double PricePerNight { get; set; }
    

    [Column("availlability")]
    public bool Availability { get; set; }

    [Column("max_occupancy_person")]
    public byte MaxOccupancyPerson { get; set; }

    // Foreign keys

    // Foreign key to RoomType
    [ForeignKey("RoomTypeId")]
    public RoomType RoomType { get; set; }


    public Room(string roomNumber, int roomTypeId, double pricePerNight, bool availability, byte maxOccupancyPerson)
    {
        RoomNumber = roomNumber.ToLower().Trim();
        RoomTypeId = roomTypeId;
        PricePerNight = pricePerNight;
        Availability = availability;
        MaxOccupancyPerson = maxOccupancyPerson;
    }
}

