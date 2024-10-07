

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

   
    [Column("first_Name")]
    public string FirstName { get; set; }

   
    [Column("last_Name")]
    public string LastName { get; set; }

   
    [Column("email")]
    public string Email { get; set; }

 
    [Column("Iientification_Number")]
    public string IdentificationNumber { get; set; }

   
    [Column("phone_Number")]
    public string PhoneNumber { get; set; }

    [Column("birth_date")]
    public DateOnly BirthDate { get; set; }


    public Guest(string firstName, string lastName, string email, string identificationNumber, string phoneNumber, DateOnly birthDate)
    {
        FirstName = firstName.ToLower().Trim();
        LastName = lastName.ToLower().Trim();
        Email = email.ToLower().Trim();
        IdentificationNumber = identificationNumber;
        PhoneNumber = phoneNumber.ToLower().Trim();
        BirthDate = birthDate;
    }

}








