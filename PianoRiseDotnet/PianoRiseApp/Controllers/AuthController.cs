using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PianoRiseManagement.Data;
using PianoRiseManagement.Models;
using PianoRiseManagement.ViewModels;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PianoRiseApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AuthController(ApplicationDbContext context) => _context = context;

        // GET: /Auth/Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            var vm = new LoginViewModel { ReturnUrl = returnUrl };
            return View(vm);
        }

        // POST: /Auth/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var hash = HashPassword(vm.Contrasena);
            var usuario = await _context.usuario
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u =>
                    u.CorreoElectronico == vm.Correo &&
                    u.ContrasenaHash     == hash &&
                    u.EstaActivo        &&
                    (u.Rol.Nombre == "Docente" || u.Rol.Nombre == "Admin"));

            if (usuario == null)
            {
                ModelState.AddModelError(string.Empty, "Credenciales inválidas o acceso no autorizado.");
                return View(vm);
            }

            // Crear claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.NombreCompleto),
                new Claim(ClaimTypes.Email, usuario.CorreoElectronico),
                new Claim(ClaimTypes.Role, usuario.Rol.Nombre),
                new Claim("UsuarioId", usuario.Id.ToString())
            };
            var principal = new ClaimsPrincipal(
                new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme)
            );

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            // Redirigir de forma segura
            if (!string.IsNullOrEmpty(vm.ReturnUrl) && Url.IsLocalUrl(vm.ReturnUrl))
                return LocalRedirect(vm.ReturnUrl);

            return usuario.Rol.Nombre == "Admin"
                ? RedirectToAction("Index", "Admin")
                : RedirectToAction("Index", "Docente");
        }

        // POST: /Auth/Logout
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }

        // GET: /Auth/AccessDenied
        [HttpGet]
        public IActionResult AccessDenied()
            => View();

        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash  = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
