
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_JulianForero.Model;

[Table("employees")]
public class Employee
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


    [Column("password")]
    public string Password { get; set; }


    public Employee(string firstName, string lastName, string email, string identificationNumber, string password)
    {
        FirstName = firstName.ToLower().Trim();
        LastName = lastName.ToLower().Trim();
        Email = email;
        IdentificationNumber = identificationNumber;
        Password = password;
    }
}
