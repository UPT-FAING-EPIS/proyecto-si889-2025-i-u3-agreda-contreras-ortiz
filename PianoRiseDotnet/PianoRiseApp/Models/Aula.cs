using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        [ForeignKey("Docente")]
        public int DocenteId { get; set; }

        public DateTime CreadoEn { get; set; }

        public Usuario Docente { get; set; } = null!;
        public ICollection<AlumnoAula> AlumnoAulas { get; set; } = new List<AlumnoAula>();
        public ICollection<AulaCancion> AulaCanciones { get; set; } = new List<AulaCancion>();
        public ICollection<Historial> Historiales { get; set; } = new List<Historial>();
    }
}
