using Microsoft.EntityFrameworkCore;
using PianoRiseManagement.Models;

namespace PianoRiseManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<AulaCancion> AulaCanciones { get; set; }
        public DbSet<AlumnoAula> AlumnoAulas { get; set; }
        public DbSet<Historial> Historiales { get; set; }

    }
}
