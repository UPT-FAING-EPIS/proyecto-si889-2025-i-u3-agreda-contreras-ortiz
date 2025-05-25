using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    public class AulaCancion
    {
        public int Id { get; set; }

        [ForeignKey("Aula")]
        public int AulaId { get; set; }

        [ForeignKey("Cancion")]
        public int CancionId { get; set; }

        public DateTime AsignadoEn { get; set; }

        public Aula Aula { get; set; } = null!;
        public Cancion Cancion { get; set; } = null!;
    }
}
