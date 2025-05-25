namespace PianoRiseManagement.Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public int Nivel { get; set; }
        public string Compositor { get; set; } = null!;
        public DateTime CreadoEn { get; set; }

        public ICollection<AulaCancion> AulaCanciones { get; set; } = new List<AulaCancion>();
        public ICollection<Historial> Historiales { get; set; } = new List<Historial>();
    }
}
