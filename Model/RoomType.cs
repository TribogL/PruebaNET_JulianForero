
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_JulianForero.Model;

[Table("room_types")]
public class RoomType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

   
    [Column("name")]
    public string Name { get; set; }

  
    [Column("description")]
    public string Description { get; set; }



    public RoomType(string name, string description)
    {
        Name = name.ToLower().Trim();
        Description = description.ToLower().Trim();
    }

}
