using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PianoRiseManagement.ViewModels;
using PianoRiseManagement.Data;
using PianoRiseManagement.Models;

namespace PianoRiseApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<UsuariosController> _logger;

        public UsuariosController(ApplicationDbContext context, ILogger<UsuariosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Sólo usuarios con Rol = Docente
        private IQueryable<Usuario> Docentes =>
            _context.usuario
                    .Include(u => u.Rol)
                    .Where(u => u.Rol.Nombre == "Docente");

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Listado de docentes solicitado.");
            return View(await Docentes.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            _logger.LogInformation("Details GET id={Id}", id);
            if (id == null)
            {
                _logger.LogWarning("Details: id es null.");
                return NotFound();
            }

            var usuario = await Docentes.FirstOrDefaultAsync(u => u.Id == id);
            if (usuario == null)
            {
                _logger.LogWarning("Details: docente no encontrado con id={Id}.", id);
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            _logger.LogInformation("Create GET");
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Usuario usuario, string VerificarContrasena)
        {
            _logger.LogInformation("Create POST data: {Usuario}", usuario);
            if (usuario.ContrasenaHash != VerificarContrasena)
            {
                _logger.LogWarning("Las contraseñas no coinciden para usuario {Nombre}.", usuario.NombreCompleto);
                ViewData["ErrorContrasena"] = "Las contraseñas no coinciden.";
                return View(usuario);
            }

            var docenteRole = await _context.rol.FirstOrDefaultAsync(r => r.Nombre == "Docente");
            if (docenteRole == null)
            {
                _logger.LogError("No existe el rol Docente en la base.");
                ModelState.AddModelError(string.Empty, "No existe el rol Docente.");
                return View(usuario);
            }
            usuario.RolId = docenteRole.Id;

            usuario.FechaRegistro = DateTime.UtcNow;
            if (usuario.FechaNacimiento.HasValue)
                usuario.FechaNacimiento = DateTime.SpecifyKind(usuario.FechaNacimiento.Value, DateTimeKind.Utc);

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Create POST invalid ModelState para usuario {Nombre}.", usuario.NombreCompleto);
                return View(usuario);
            }

            usuario.ContrasenaHash = HashPassword(usuario.ContrasenaHash);
            _context.Add(usuario);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Usuario docente creado con id={Id}.", usuario.Id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var usuario = await _context.usuario
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.Id == id && u.Rol!.Nombre == "Docente");
            if (usuario == null) return NotFound();

            // Mapear a VM
            var vm = new DocenteEditViewModel
            {
                Id = usuario.Id,
                NombreCompleto = usuario.NombreCompleto,
                CorreoElectronico = usuario.CorreoElectronico,
                Telefono = usuario.Telefono,
                EstaActivo = usuario.EstaActivo
            };
            return View(vm);
        }

        // POST: Usuarios/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DocenteEditViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            // Cargar la entidad trackeada
            var usuarioDb = await _context.usuario
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.Id == vm.Id && u.Rol!.Nombre == "Docente");
            if (usuarioDb == null) return NotFound();

            // Aplicar cambios
            usuarioDb.NombreCompleto = vm.NombreCompleto;
            usuarioDb.CorreoElectronico = vm.CorreoElectronico;
            usuarioDb.Telefono = vm.Telefono;
            usuarioDb.EstaActivo = vm.EstaActivo;

            // Si ingresó nueva contraseña, actualízala
            if (!string.IsNullOrWhiteSpace(vm.NuevaContrasena))
                usuarioDb.ContrasenaHash = HashPassword(vm.NuevaContrasena);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            _logger.LogInformation("Delete GET id={Id}", id);
            if (id == null)
            {
                _logger.LogWarning("Delete GET: id es null.");
                return NotFound();
            }

            var usuario = await Docentes.FirstOrDefaultAsync(u => u.Id == id);
            if (usuario == null)
            {
                _logger.LogWarning("Delete GET: docente no encontrado id={Id}.", id);
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _logger.LogInformation("Delete POST id={Id}", id);

            var usuario = await _context.usuario
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (usuario == null)
            {
                _logger.LogWarning("Delete POST: docente no encontrado id={Id}.", id);
            }
            else if (usuario.Rol == null || usuario.Rol.Nombre != "Docente")
            {
                _logger.LogWarning("Delete POST: rol no válido para eliminar id={Id}, rol={Rol}.", id, usuario.Rol?.Nombre);
            }
            else
            {
                _context.usuario.Remove(usuario);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Usuario docente eliminado id={Id}.", id);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
            => _context.usuario.Any(e => e.Id == id && e.Rol != null && e.Rol.Nombre == "Docente");

        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
