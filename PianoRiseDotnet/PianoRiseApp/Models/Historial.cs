using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    public class Historial
    {
        public int Id { get; set; }

        [ForeignKey("Alumno")]
        public int AlumnoId { get; set; }

        [ForeignKey("Aula")]
        public int AulaId { get; set; }

        [ForeignKey("Cancion")]
        public int CancionId { get; set; }

        public decimal Precision { get; set; }
        public int Errores { get; set; }
        public TimeSpan Duracion { get; set; }
        public DateTime RegistradoEn { get; set; }

        public Usuario Alumno { get; set; } = null!;
        public Aula Aula { get; set; } = null!;
        public Cancion Cancion { get; set; } = null!;
    }
}
