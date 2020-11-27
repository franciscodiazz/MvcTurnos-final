using Microsoft.EntityFrameworkCore;
using MvcTurnos.Models;

namespace MvcTurnos.Data
{
    public class MvcTurnoContext : DbContext
    {
        public MvcTurnoContext(DbContextOptions<MvcTurnoContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Turno> Turno { get; set; }

    }
}