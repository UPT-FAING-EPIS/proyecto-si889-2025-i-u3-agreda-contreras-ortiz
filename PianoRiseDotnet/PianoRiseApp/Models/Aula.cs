using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    [Table("aula")]
    public class Aula
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("descripcion")]
        public string Descripcion { get; set; } = null!;

        [Column("docente_id"), ForeignKey("Docente")]
        public int DocenteId { get; set; }

        [Column("creado_en")]
        public DateTime CreadoEn { get; set; }

        [Required(ErrorMessage = "El grado es obligatorio.")]
        [Range(1, 5, ErrorMessage = "El grado debe estar entre 1 y 5.")]
        [Column("grado")]
        public short? Grado { get; set; }

        [Required(ErrorMessage = "La sección es obligatoria.")]
        [RegularExpression(@"^[A-Z]$", ErrorMessage = "La sección debe ser una sola letra mayúscula (A-Z).")]
        [MaxLength(1)]
        [Column("seccion")]
        public string? Seccion { get; set; }

        [Column("anio")]
        public short? Anio { get; set; }

        [MaxLength(4, ErrorMessage = "El código no debe tener más de 4 caracteres.")]
        [Column("codigo")]
        public string? Codigo { get; set; }

        [Column("estado")]
        public bool Estado { get; set; } = true;

        public Usuario? Docente { get; set; }

        public ICollection<AlumnoAula> AlumnoAulas { get; set; } = new List<AlumnoAula>();

        public ICollection<AulaCancion> AulaCanciones { get; set; } = new List<AulaCancion>();

        public ICollection<Historial> Historiales { get; set; } = new List<Historial>();
    }
}
