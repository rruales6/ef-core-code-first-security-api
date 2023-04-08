using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AltusERP_DB.Model;

public class Rol
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RolId { get; set; }
    public string RolName { get; set; }
    public string RolDescription { get; set; }
    public ICollection<User> RolUsers { get; set; }
}