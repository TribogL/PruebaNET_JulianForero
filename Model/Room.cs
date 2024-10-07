

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

    [MaxLength(250)]
    [Column("room_number")]
    public string RoomNumber { get; set; }

    // Foreign key to RoomType
    [Column("room_type_id")]
    public int RoomTypeId { get; set; }


    [ForeignKey("RoomTypeId")]
    public RoomType RoomType { get; set; }

    [Column("price_per_nigth")]
    public double PricePerNight { get; set; }

    [Column("availlability")]
    public bool Availability { get; set; }

    [Column("max_occupancy_person")]
    public byte MaxOccupancyPerson { get; set; }


    public Room(string roomNumber, int roomTypeId, double pricePereNigth, bool availlability, byte maxOccupancyPerson)
    {
        RoomNumber = roomNumber;
        RoomTypeId = roomTypeId;
        PricePerNight = pricePereNigth;
        Availability = availlability;
        MaxOccupancyPerson = maxOccupancyPerson;
    }
}

