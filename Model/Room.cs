using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_JulianForero.Model;
public class Room : RoomType
{
    public int Id { get; set; }
    public int RoomNumber { get; set; }
    public double PricePerNigth { get; set; }
    public bool Availlability { get; set; }
    public byte MaxOccupancyPerson { get; set; }


}
