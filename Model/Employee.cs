
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

    [MaxLength(50)]
    [Column("first_Name")]
    public string FirstName { get; set; }

    [MaxLength(50)]
    [Column("last_Name")]
    public string LastName { get; set; }

    [MaxLength(255)]
    [Column("email")]
    public string Email { get; set; }
    
    [MaxLength(20)]
    [Column("Iientification_Number")]
    public string IdentificationNumber { get; set; }

    [MaxLength(255)]
    [Column("password")]
    public string Password { get; set; }


    public Employee(string firstName, string lastName, string email, string IdentificationNumber, string password)
    {
        FirstName = firstName; 
        LastName = lastName; 
        Email = email;
        Password = password;
    }
}
