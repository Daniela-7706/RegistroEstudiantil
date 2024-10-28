using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RegistroEstudiantil.Models;

namespace RegistroEstudiantil.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Estudiante>Estudiantes { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Matricula> Matriculas { get; set; }

    }
}
