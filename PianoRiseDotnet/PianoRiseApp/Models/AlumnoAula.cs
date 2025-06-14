using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PianoRiseManagement.Models
{
    [Table("alumno_aula")]
    public class AlumnoAula
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("alumno_id"), ForeignKey("Alumno")]
        public int AlumnoId { get; set; }

        [Column("aula_id"), ForeignKey("Aula")]
        public int AulaId { get; set; }

        [Column("inscrito_en")]
        public DateTime InscritoEn { get; set; }

        public Usuario Alumno { get; set; } = null!;
        public Aula Aula { get; set; } = null!;
    }
}