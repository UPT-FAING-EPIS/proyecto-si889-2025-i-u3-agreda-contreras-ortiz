using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    [Table("historial")]
    public class Historial
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("alumno_id"), ForeignKey("Alumno")]
        public int AlumnoId { get; set; }

        [Column("aula_id"), ForeignKey("Aula")]
        public int AulaId { get; set; }

        [Column("cancion_id"), ForeignKey("Cancion")]
        public int CancionId { get; set; }

        [Column("precision")]
        public decimal Precision { get; set; }

        [Column("errores")]
        public int Errores { get; set; }

        [Column("duracion")]
        public TimeSpan Duracion { get; set; }

        [Column("registrado_en")]
        public DateTime RegistradoEn { get; set; }

        public Usuario Alumno  { get; set; } = null!;
        public Aula    Aula    { get; set; } = null!;
        public Cancion Cancion { get; set; } = null!;
    }
}
