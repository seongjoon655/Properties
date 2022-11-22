using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace VisualAcademy.Models
{
    [Table("Propertiy")]
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool Active { get; set; }
    }
}
