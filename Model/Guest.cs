

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_JulianForero.Model;

[Table("guests")]
public class Guest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [MaxLength(255)]
    [Column("first_Name")]
    public string FirstName { get; set; }

    [MaxLength(255)]
    [Column("last_Name")]
    public string LastName { get; set; }

    [MaxLength(255)]
    [Column("email")]
    public string Email { get; set; }

    [MaxLength(20)]
    [Column("Iientification_Number")]
    public string IdentificationNumber { get; set; }

    [MaxLength(20)]
    [Column("phone_Number")]
    public string PhoneNumber { get; set; }

    [Column("birth_date")]
    public DateOnly BirthDate { get; set; }


    public Guest(string firstName, string lastName, string email, string IdentificationNumber, string phoneNumber, DateOnly birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        BirthDate = birthDate;
    }

}








