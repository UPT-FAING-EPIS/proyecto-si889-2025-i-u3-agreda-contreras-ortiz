namespace PianoRiseManagement.Models.ViewModels
{
    public class ProgresoAlumno
    {
        public string NombreCompleto { get; set; } = "";
        public double PorcentajeAvance { get; set; }
        public int Intentos { get; set; }
        public int TotalErrores { get; set; }
        public TimeSpan DuracionTotal { get; set; }
    }

    public class ResumenCancion
    {
        public string Titulo { get; set; } = "";
        public int TotalAlumnos { get; set; }
        public int TotalErrores { get; set; }
        public TimeSpan DuracionAcumulada { get; set; }
        public int TotalIntentos { get; set; }
    }

    public class AulaDetalleViewModel
    {
        public Aula Aula { get; set; } = null!;

        public List<AlumnoAula> AlumnosInscritos { get; set; } = new();
        public List<Cancion> CancionesDisponibles { get; set; } = new();
        public List<AulaCancion> CancionesAsignadas { get; set; } = new();

        public List<ProgresoAlumno> Progresos { get; set; } = new();
        public Dictionary<string, List<ProgresoAlumno>> ReportesPorCancion { get; set; } = new();
        public List<ResumenCancion> ResumenesCanciones { get; set; } = new();
    }
}
