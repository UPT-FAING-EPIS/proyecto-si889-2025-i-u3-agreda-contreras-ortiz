using System.ComponentModel.DataAnnotations;

namespace PianoRiseManagement.ViewModels
{
    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string Correo { get; set; } = string.Empty;

        [Required, DataType(DataType.Password)]
        public string Contrasena { get; set; } = string.Empty;

        public string? ReturnUrl { get; set; }
    }
}
