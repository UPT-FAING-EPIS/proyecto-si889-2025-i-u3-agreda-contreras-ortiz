using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    [Table("rol")]
    public class Rol
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("nombre")]
        public string Nombre { get; set; } = null!;

        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
