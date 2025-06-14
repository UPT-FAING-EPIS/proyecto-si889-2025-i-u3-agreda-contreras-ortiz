using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre completo es obligatorio.")]
        [MaxLength(100)]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$", ErrorMessage = "El nombre solo debe contener letras y espacios.")]
        [Column("nombre_completo")]
        public string NombreCompleto { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        [Column("correo_electronico")]
        public string CorreoElectronico { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        [Column("contrasena_hash")]
        public string ContrasenaHash { get; set; } = null!;

        [Column("rol_id")]
        public int RolId { get; set; }

        [ForeignKey(nameof(RolId))]
        public Rol? Rol { get; set; }

        [MaxLength(15)]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El teléfono debe tener 9 dígitos.")]
        [Column("telefono")]
        public string? Telefono { get; set; }

        [Column("fecha_registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [Column("fecha_nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Column("esta_activo")]
        public bool EstaActivo { get; set; } = true;

        public ICollection<Aula>? AulasDocente { get; set; }
        public ICollection<AlumnoAula>? AlumnoAulas { get; set; }
        public ICollection<Historial>? Historiales { get; set; }
    }
}
