using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    [Table("aula_cancion")]
    public class AulaCancion
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("aula_id"), ForeignKey("Aula")]
        public int AulaId { get; set; }

        [Column("cancion_id"), ForeignKey("Cancion")]
        public int CancionId { get; set; }

        [Column("asignado_en")]
        public DateTime AsignadoEn { get; set; }

        public Aula Aula { get; set; } = null!;
        public Cancion Cancion { get; set; } = null!;
    }
}
