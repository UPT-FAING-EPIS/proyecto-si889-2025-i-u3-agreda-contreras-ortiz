using System.ComponentModel.DataAnnotations;

namespace PianoRiseManagement.ViewModels
{
    public class DocenteEditViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        [Display(Name = "Nombre completo")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required, EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string CorreoElectronico { get; set; } = string.Empty;

        [Phone]
        [Display(Name = "Teléfono")]
        public string? Telefono { get; set; }

        [Display(Name = "Activo")]
        public bool EstaActivo { get; set; }

        [DataType(DataType.Password), MinLength(6)]
        [Display(Name = "Nueva contraseña (opcional)")]
        public string? NuevaContrasena { get; set; }

        [DataType(DataType.Password), Compare("NuevaContrasena")]
        [Display(Name = "Confirmar contraseña")]
        public string? ConfirmarContrasena { get; set; }
    }
}
