using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    public class AlumnoAula
    {
        public int Id { get; set; }

        [ForeignKey("Alumno")]
        public int AlumnoId { get; set; }

        [ForeignKey("Aula")]
        public int AulaId { get; set; }

        public DateTime InscritoEn { get; set; }

        public Usuario Alumno { get; set; } = null!;
        public Aula Aula { get; set; } = null!;
    }
}
