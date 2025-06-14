using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PianoRiseManagement.Data;
using PianoRiseManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace PianoRiseManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AulasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AulasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var aulas = _context.aula.Include(a => a.Docente);
            return View(await aulas.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var aula = await _context.aula
                .Include(a => a.Docente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aula == null) return NotFound();

            return View(aula);
        }

        public IActionResult Create()
        {
            ViewData["DocenteId"] = new SelectList(
                _context.usuario.Where(u => u.Rol.Nombre == "Docente"),
                "Id", "NombreCompleto"
            );

            return View(new Aula
            {
                Estado = true,
                CreadoEn = DateTime.UtcNow,
                Anio = (short)DateTime.Now.Year,
                Codigo = GenerarCodigoUnico() // << Genera el código por defecto

            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Aula aula)
        {
            if (!Request.Form.ContainsKey("Estado"))
                aula.Estado = false;

            aula.CreadoEn = DateTime.UtcNow;
            aula.Anio = (short)DateTime.Now.Year;

            // Validación de unicidad: Grado + Sección (insensible a may/min) + Año
            var existeAula = await _context.aula.AnyAsync(a =>
        a.Grado == aula.Grado &&
        a.Anio == aula.Anio &&
        a.Seccion != null &&
        aula.Seccion != null &&
        a.Seccion.ToUpper() == aula.Seccion.ToUpper()
    );

            if (existeAula)
            {
                ModelState.AddModelError(string.Empty, "Ya existe un aula con el mismo grado, sección y año.");

                ViewData["DocenteId"] = new SelectList(
                    _context.usuario.Where(u => u.Rol.Nombre == "Docente"),
                    "Id", "NombreCompleto", aula.DocenteId
                );

                return View(aula);
            }

            if (!ModelState.IsValid)
            {
                ViewData["DocenteId"] = new SelectList(
                    _context.usuario.Where(u => u.Rol.Nombre == "Docente"),
                    "Id", "NombreCompleto", aula.DocenteId
                );

                return View(aula);
            }

            try
            {
                _context.Add(aula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❗ Error al guardar el aula: {ex.Message}");

                ViewData["DocenteId"] = new SelectList(
                    _context.usuario.Where(u => u.Rol.Nombre == "Docente"),
                    "Id", "NombreCompleto", aula.DocenteId
                );

                return View(aula);
            }
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var aula = await _context.aula.FindAsync(id);
            if (aula == null) return NotFound();

            ViewData["DocenteId"] = new SelectList(
                _context.usuario.Where(u => u.Rol.Nombre == "Docente"),
                "Id", "NombreCompleto", aula.DocenteId
            );
            return View(aula);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Aula aula)
        {
            if (id != aula.Id) return NotFound();

            if (!Request.Form.ContainsKey("Estado"))
                aula.Estado = false;

            // Verifica si ya existe un aula con los mismos datos (excepto el mismo ID)
            var existeAula = await _context.aula.AnyAsync(a =>
                a.Id != aula.Id &&
                a.Grado == aula.Grado &&
                a.Anio == aula.Anio &&
                a.Seccion != null &&
                aula.Seccion != null &&
                a.Seccion.ToUpper() == aula.Seccion.ToUpper()
            );

            if (existeAula)
            {
                ModelState.AddModelError(string.Empty, "Ya existe un aula con el mismo grado, sección y año.");
            }

            if (!ModelState.IsValid)
            {
                ViewData["DocenteId"] = new SelectList(
                    _context.usuario.Where(u => u.Rol.Nombre == "Docente"),
                    "Id", "NombreCompleto", aula.DocenteId
                );
                return View(aula);
            }

            try
            {
                _context.Update(aula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.aula.Any(e => e.Id == id))
                    return NotFound();
                else throw;
            }
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var aula = await _context.aula
                .Include(a => a.Docente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aula == null) return NotFound();

            return View(aula);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aula = await _context.aula.FindAsync(id);
            if (aula != null)
            {
                _context.aula.Remove(aula);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private string GenerarCodigoUnico()
        {
            var random = new Random();
            string codigo;

            do
            {
                int numero = random.Next(0, 100); // de 00 a 99
                codigo = $"AU{numero:D2}"; // AU00, AU01, ..., AU99
            }
            while (_context.aula.Any(a => a.Codigo == codigo));

            return codigo;
        }

    }
    
}
