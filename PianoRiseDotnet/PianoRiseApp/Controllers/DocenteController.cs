using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PianoRiseManagement.Data;
using PianoRiseManagement.Models;
using PianoRiseManagement.Models.ViewModels; // Asegúrate de tener este using
using System.Security.Claims;

namespace PianoRiseApp.Controllers
{
    [Authorize(Roles = "Docente")]
    public class DocenteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocenteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Docente/Index
        public async Task<IActionResult> Index()
        {
            var correo = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(correo))
                return RedirectToAction("Login", "Auth");

            var docente = await _context.usuario
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.CorreoElectronico == correo && u.Rol.Nombre == "Docente");

            if (docente == null)
                return Unauthorized();

            var aulas = await _context.aula
                .Where(a => a.DocenteId == docente.Id)
                .OrderByDescending(a => a.CreadoEn)
                .ToListAsync();

            return View(aulas);
        }

        public async Task<IActionResult> DetalleAula(int id)
        {
            var correo = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (string.IsNullOrEmpty(correo))
                return RedirectToAction("Login", "Auth");

            var docente = await _context.usuario
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.CorreoElectronico == correo && u.Rol.Nombre == "Docente");

            if (docente == null)
                return Unauthorized();

            var aula = await _context.aula
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id && a.DocenteId == docente.Id);

            if (aula == null)
                return NotFound();

            var alumnos = await _context.alumno_aula
                .Include(aa => aa.Alumno)
                .Where(aa => aa.AulaId == id)
                .ToListAsync();

            var cancionesAsignadasIds = await _context.aula_cancion
                .Where(ac => ac.AulaId == id)
                .Select(ac => ac.CancionId)
                .ToListAsync();

            var cancionesAsignadas = await _context.aula_cancion
                .Include(ac => ac.Cancion)
                .Where(ac => ac.AulaId == id)
                .ToListAsync();

            var cancionesDisponibles = await _context.cancion
                .Where(c => c.Estado && !cancionesAsignadasIds.Contains(c.Id))
                .ToListAsync();

            // OPTIMIZACIÓN: se obtiene historial filtrado una sola vez
            var historialFiltrado = await _context.historial
                .Where(h => h.AulaId == id)
                .ToListAsync();

            // === REPORTE DETALLADO POR CANCIÓN ===
            var reportesPorCancion = new Dictionary<string, List<ProgresoAlumno>>();

            foreach (var ac in cancionesAsignadas)
            {
                var progresos = alumnos.Select(aa =>
                {
                    var registros = historialFiltrado
                        .Where(h => h.AlumnoId == aa.AlumnoId && h.CancionId == ac.CancionId)
                        .ToList();

                    var promedio = registros.Any() ? registros.Average(h => (double)h.Precision) : 0;

                    return new ProgresoAlumno
                    {
                        NombreCompleto = aa.Alumno.NombreCompleto,
                        PorcentajeAvance = Math.Round(promedio, 2),
                        Intentos = registros.Count,
                        TotalErrores = registros.Sum(h => h.Errores),
                        DuracionTotal = registros.Any() ? TimeSpan.FromTicks(registros.Sum(h => h.Duracion.Ticks)) : TimeSpan.Zero
                    };
                }).OrderByDescending(p => p.PorcentajeAvance).ToList();

                reportesPorCancion[ac.Cancion.Titulo] = progresos;
            }

            // === RESUMENES POR CANCIÓN ===
            var resumenesCanciones = cancionesAsignadas.Select(ac =>
            {
                var registros = historialFiltrado
                    .Where(h => h.CancionId == ac.CancionId)
                    .ToList();

                return new ResumenCancion
                {
                    Titulo = ac.Cancion.Titulo,
                    TotalAlumnos = registros.Select(r => r.AlumnoId).Distinct().Count(),
                    TotalErrores = registros.Sum(r => r.Errores),
                    TotalIntentos = registros.Count,
                    DuracionAcumulada = registros.Any() ? TimeSpan.FromTicks(registros.Sum(r => r.Duracion.Ticks)) : TimeSpan.Zero
                };
            }).ToList();

            // === RETORNAR VISTA ===
            var viewModel = new AulaDetalleViewModel
            {
                Aula = aula,
                AlumnosInscritos = alumnos,
                CancionesDisponibles = cancionesDisponibles,
                CancionesAsignadas = cancionesAsignadas,
                ReportesPorCancion = reportesPorCancion,
                ResumenesCanciones = resumenesCanciones
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ExpulsarAlumno(int aulaId, int alumnoId)
        {
            var correo = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(correo))
                return RedirectToAction("Login", "Auth");

            var docente = await _context.usuario
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.CorreoElectronico == correo && u.Rol.Nombre == "Docente");

            if (docente == null)
                return Unauthorized();

            var aula = await _context.aula
                .FirstOrDefaultAsync(a => a.Id == aulaId && a.DocenteId == docente.Id);

            if (aula == null)
                return Unauthorized();

            var registro = await _context.alumno_aula
                .FirstOrDefaultAsync(aa => aa.AulaId == aulaId && aa.AlumnoId == alumnoId);

            if (registro != null)
            {
                _context.alumno_aula.Remove(registro);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("DetalleAula", new { id = aulaId });
        }

        [HttpPost]
        public async Task<IActionResult> AgregarCancionAula(int aulaId, int cancionId)
        {
            var yaAsignada = await _context.aula_cancion
                .AnyAsync(ac => ac.AulaId == aulaId && ac.CancionId == cancionId);

            if (!yaAsignada)
            {
                _context.aula_cancion.Add(new AulaCancion
                {
                    AulaId = aulaId,
                    CancionId = cancionId,
                    AsignadoEn = DateTime.UtcNow
                });
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("DetalleAula", new { id = aulaId });
        }

        [HttpPost]
        public async Task<IActionResult> EliminarCancionAula(int aulaId, int cancionId)
        {
            var registro = await _context.aula_cancion
                .FirstOrDefaultAsync(ac => ac.AulaId == aulaId && ac.CancionId == cancionId);

            if (registro != null)
            {
                _context.aula_cancion.Remove(registro);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("DetalleAula", new { id = aulaId });
        }
    }
}
