using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PianoRiseManagement.Data;
using PianoRiseManagement.Models;
using System.Security.Claims;


namespace PianoRiseApp.Controllers
{
     [Authorize(Roles = "Admin")]
    public class CancionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CancionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.cancion.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cancion cancion)
        {
            if (ModelState.IsValid)
            {
                cancion.CreadoEn = DateTime.UtcNow;
                _context.Add(cancion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cancion);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var cancion = await _context.cancion.FindAsync(id);
            if (cancion == null) return NotFound();

            return View(cancion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cancion cancion)
        {
            if (id != cancion.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // Forzar fecha a UTC si viene sin especificar
                    if (cancion.CreadoEn.Kind == DateTimeKind.Unspecified)
                    {
                        cancion.CreadoEn = DateTime.SpecifyKind(cancion.CreadoEn, DateTimeKind.Utc);
                    }

                    _context.Update(cancion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.cancion.Any(e => e.Id == cancion.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(cancion);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var cancion = await _context.cancion.FirstOrDefaultAsync(m => m.Id == id);
            if (cancion == null) return NotFound();

            Console.WriteLine("NotasJson: " + cancion.NotasJson);
            Console.WriteLine("Notas deserializadas: " + string.Join(", ", cancion.Notas));

            return View(cancion);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var cancion = await _context.cancion.FirstOrDefaultAsync(m => m.Id == id);
            if (cancion == null) return NotFound();

            return View(cancion);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cancion = await _context.cancion.FindAsync(id);
            if (cancion != null)
            {
                _context.cancion.Remove(cancion);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
