using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace PianoRiseManagement.Models
{
    [Table("cancion")]
    public class Cancion
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$", ErrorMessage = "El título solo debe contener letras y espacios.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "El título debe tener entre 2 y 200 caracteres.")]
        [Column("titulo")]
        public string Titulo { get; set; } = null!;

        [Required(ErrorMessage = "El nivel es obligatorio.")]
        [Range(1, 3, ErrorMessage = "El nivel debe estar entre 1 y 3.")]
        [Column("nivel")]
        public int Nivel { get; set; }

       [Required(ErrorMessage = "El compositor es obligatorio.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$", ErrorMessage = "El compositor solo debe contener letras y espacios.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre del compositor debe tener entre 2 y 200 caracteres.")]
        [Column("compositor")]
        public string Compositor { get; set; } = null!;

        [Required]
        [Column("creado_en")]
        public DateTime CreadoEn { get; set; }

        [Column("estado")]
        public bool Estado { get; set; }

        [Column("notas", TypeName = "jsonb")]
        public string NotasJson { get; set; } = "[]";

        [NotMapped]
        public List<string> Notas
        {
            get => JsonSerializer.Deserialize<List<string>>(NotasJson) ?? new();
            set => NotasJson = JsonSerializer.Serialize(value);
        }

        public ICollection<AulaCancion> AulaCanciones { get; set; } = new List<AulaCancion>();
        public ICollection<Historial> Historiales    { get; set; } = new List<Historial>();
    }
}
