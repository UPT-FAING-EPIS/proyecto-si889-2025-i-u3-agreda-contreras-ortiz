using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PianoRiseManagement.Models;

namespace PianoRiseManagement.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public string Apellido { get; set; } = null!;

        [Required]
        public string UsuarioNombre { get; set; } = null!;

        [Required]
        public string Contrasena { get; set; } = null!;

        [Required, EmailAddress]
        public string Correo { get; set; } = null!;

        [ForeignKey("Rol")]
        public int RolId { get; set; }

        public bool Activo { get; set; }
        public DateTime CreadoEn { get; set; }

        public Rol Rol { get; set; } = null!;

        public ICollection<Aula> Aulas { get; set; } = new List<Aula>();
        public ICollection<Historial> Historiales { get; set; } = new List<Historial>();
        public ICollection<AlumnoAula> AlumnoAulas { get; set; } = new List<AlumnoAula>();
    }
}