

namespace PruebaNET_JulianForero.Model;
public class Guest
{
public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string IdentificationNumber { get; set; }
    public string PhoneNumber { get; set; }
    public DateOnly BirthDate { get; set; }

}
