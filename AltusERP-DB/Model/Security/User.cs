using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AltusERP_DB.Model;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long UserId { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public int RolId { get; set; }
    [ForeignKey("RolId")]
    public Rol UserRol{ get; set; }
}