
using Microsoft.EntityFrameworkCore;
using PruebaNET_JulianForero.Model;

namespace PruebaNET_JulianForero.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


}
